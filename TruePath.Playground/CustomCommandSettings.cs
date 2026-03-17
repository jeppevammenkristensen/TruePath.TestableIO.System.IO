using FileBasedApp.Toolkit;
using FileBasedApp.Toolkit.CommandCli;
using Spectre.Console;
using Spectre.Console.Cli;
using TruePath;

public class CustomCommandSettings : ExtendedCommandSettings
{
    [CommandArgument(0, "<directory-path>")]
    public string? Directory { get; set; }
    [CommandOption("--filePath")]
    public required string File { get; set; }

    public AbsolutePath DirectoryPath { get; set; }
    
    public AbsolutePath FilePath { get; set; }
    
    protected override ValidationResult DoValidate()
    {
        // Evaluates the directory string.
        DirectoryPath = TryGetDirectory(Directory,
            allowEmpty: true,
            shouldExist: true,
            PredefinedRootPath.ExecutionFolder);
        FilePath = TryGetFile(File, true, roots: [PathUtil.GetCurrentWorkingFolder(), PathUtil.GetExecutionFolder()]);
        return base.DoValidate();
    }
}