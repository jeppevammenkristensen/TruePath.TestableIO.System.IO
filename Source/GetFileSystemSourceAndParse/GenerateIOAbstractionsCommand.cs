using System.ComponentModel;
using System.IO.Abstractions;
using FileBasedApp.Toolkit;
using FileBasedApp.Toolkit.CommandCli;
using GetFileSystemSourceAndParse;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using Spectre.Console;
using Spectre.Console.Cli;
using TruePath;
using ValidationResult = Spectre.Console.ValidationResult;

/// <summary>
/// Represents a command to generate abstractions for input/output (I/O) operations (Based on Testably.Abstractions,
/// leveraging the file system abstraction layer and integrating functionalities for analyzing and processing source code.
/// It supports options for specifying paths, skipping repository fetching, and selecting interfaces to process.
/// </summary>
public class GenerateIOAbstractionsCommand : AsyncCommand<GenerateIOAbstractionsCommand.Settings>
{
    private readonly IFileSystem _fileSystem;
    private readonly IAnsiConsole _console;

    public GenerateIOAbstractionsCommand() : this(new FileSystem(), AnsiConsole.Console)
    {
    }

    internal GenerateIOAbstractionsCommand(IFileSystem fileSystem, IAnsiConsole console)
    {
        _fileSystem = fileSystem;
        _console = console;
    }

    public class Settings : ExtendedCommandSettings
    {
        [CommandOption("-p|--path")] public required string Path { get; set; }

        [CommandOption("--skip-fetch")] 
        [Description("Skip fetching or updating the repository from Github")]
        public bool SkipFetch { get; set; }


        protected override ValidationResult DoValidate()
        {
            if (string.IsNullOrWhiteSpace(Path))
            {
                PathFull =  Environment.SpecialFolder.UserProfile.GetSpecialFolder() / "FileBasedApp";
            }
            else
            {
                PathFull = TryGetDirectory(Path, true, false, PredefinedRootPath.CurrentDirectory);
            }

            return base.DoValidate();
        }

        public AbsolutePath PathFull { get; set; }
    }

    protected override async Task<int> ExecuteAsync(CommandContext context, Settings settings,
        CancellationToken cancellationToken)
    {
        _fileSystem.Directory.CreateDirectory(settings.PathFull);

        var testablyFolder = settings.PathFull / "Testably.Abstractions"; 
        
        if (!settings.SkipFetch)
        {
            if (!_fileSystem.Directory.Exists(testablyFolder) || _fileSystem.Directory.GetFiles(testablyFolder).Length == 0)
            {
                _console.MarkupLineInterpolated($"[yellow]Directory is empty. [/]");
                await SimpleExec.Command.RunAsync("git", ["clone", "https://github.com/Testably/Testably.Abstractions.git"],
                    settings.PathFull.Value, ct: cancellationToken);    
            }

            AnsiConsole.MarkupLine($"[green][link]https://github.com/Testably/Testably.Abstractions.git[/][/]");
            await SimpleExec.Command.RunAsync("git", ["pull"], testablyFolder.Value, ct: cancellationToken);
            
        }
        else
        {
            _console.MarkupLineInterpolated($"[yellow]Skipping fetching from Github[/]");
        }

        var codePath = testablyFolder / "Source" /
                       "Testably.Abstractions.FileSystem.Interface" /
                       "Testably.Abstractions.FileSystem.Interface.csproj";

        Microsoft.Build.Locator.MSBuildLocator.RegisterDefaults();

        var properties = new Dictionary<string, string>
        {
            // This overrides the project property during load
            ["TargetFramework"] = "net10.0"
        };
        
        var workspace = MSBuildWorkspace.Create(properties);
        
        var project = await _console.Status().StartAsync("[green]Loading project[/]",
            async _ => await workspace.OpenProjectAsync(codePath.Value,cancellationToken: cancellationToken));
        
        ProjectProcessor processor = new();

        AnsiConsole.MarkupLineInterpolated($"[green]Getting compilation for project: {project.Name}[/]");
        var compilation =  await _console.Status().StartAsync("[green]Loading compilation[/]", async _ => await project.GetCompilationAsync(cancellationToken));
        
        ArgumentNullException.ThrowIfNull(compilation);
        var interfaces = ExtractInterfacesFromCompilation(compilation);

        while (true)
        {
            var namedTypeSymbol = AnsiConsole.Prompt(new SelectionPrompt<INamedTypeSymbol>()
                .Title("Select interface to process")
                .AddChoices(interfaces)
                .UseConverter(x => x.Name));
            
            try
            {
                await processor.Process(project, compilation, namedTypeSymbol, cancellationToken);
            }
            catch (Exception e)
            {
                AnsiConsole.WriteException(e);
            }
        }
    }

    private static List<INamedTypeSymbol> ExtractInterfacesFromCompilation(Compilation compilation)
    {
        var interfaces = new List<INamedTypeSymbol>();
        var result = new Stack<INamespaceOrTypeSymbol>();
        result.Push(compilation.Assembly.GlobalNamespace);

        while (result.Count > 0)
        {
            var current = result.Pop();

            foreach (var symbol in current.GetMembers())
            {
                if (symbol.Kind == SymbolKind.Namespace)
                {
                    AnsiConsole.MarkupLineInterpolated($"[green]Navigation to namespace{symbol.Name}[/]");
                    result.Push((INamespaceOrTypeSymbol) symbol);
                }
                else
                {
                    if (symbol.Kind == SymbolKind.NamedType && symbol is INamedTypeSymbol { TypeKind: TypeKind.Interface} namedType )
                    {
                        AnsiConsole.MarkupLineInterpolated($"[green]Found interface {symbol.Name}[/]");
                        interfaces.Add(namedType);
                    }
                }
            }
        }

        return interfaces;
    }
}