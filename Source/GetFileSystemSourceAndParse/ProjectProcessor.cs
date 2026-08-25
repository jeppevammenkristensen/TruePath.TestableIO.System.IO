using System.Text;
using System.Text.RegularExpressions;
using FileBasedApp.Toolkit.CSharp.Extensions;
using GetFileSystemSourceAndParse.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Spectre.Console;

namespace GetFileSystemSourceAndParse;


/// <summary>
/// A syntax rewriter that removes duplicate method declarations based on their signature (name, arity, and parameter types).
/// </summary>
public sealed class RemoveDuplicatesRewriter : CSharpSyntaxRewriter
{
    // Keep one instance per syntax tree rewrite so the set tracks what we've already seen.
    private readonly HashSet<MethodSignatureKey> _seen = new();

    /// <summary>
    /// Visits a method declaration and removes it if a method with the same signature has already been seen.
    /// </summary>
    public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
    {
        // Visit children first (safe default; not strictly required for duplicate removal)
        node = (MethodDeclarationSyntax)base.VisitMethodDeclaration(node)!;

        var key = MethodSignatureKey.From(node);

        // If we've already emitted a method with the same name+parameters, drop this one.
        // Returning null removes the node from the rewritten tree.
        if (!_seen.Add(key))
            return null;

        return node;
    }

    private readonly record struct MethodSignatureKey(
        string MethodName,
        int TypeParameterArity,
        string ParameterSignature)
    {
        public static MethodSignatureKey From(MethodDeclarationSyntax node)
        {
            var name = node.Identifier.ValueText;
            var arity = node.TypeParameterList?.Parameters.Count ?? 0;

            // "parameters match" typically needs more than just type+name.
            // This includes: ref/out/in, params, type (including nullable/arrays), and the parameter "shape".
            var parameterSig = string.Join("|",
                node.ParameterList.Parameters.Select(p =>
                {
                    var modifiers = p.Modifiers.ToFullString().Trim(); // e.g. "ref", "out", "in", "params"
                    var typeText = (p.Type?.ToString() ?? "").Trim();  // e.g. "string", "int?", "List<string>"
                    return $"{modifiers} {typeText}".Trim();
                }));

            return new MethodSignatureKey(name, arity, parameterSig);
        }
    }
}

/// <summary>
/// Processes a Roslyn <see cref="Project"/> to generate extension methods that wrap interface members with strongly-typed path parameters.
/// </summary>
public partial class ProjectProcessor
{
    /// <summary>
    /// Matches parameters like path, path1, path123 etc...
    /// </summary>
    /// <returns></returns>
    [GeneratedRegex("^path\\d*")]
    public static partial Regex PathMatcher();


    /// <summary>
    /// Generates extension methods for the specified interface type and copies the result to the clipboard.
    /// </summary>
    public async Task Process(Project project, Compilation compilation, INamedTypeSymbol typeByMetadataName,
        CancellationToken cancellationToken)
    {
        var interfaceName = typeByMetadataName.Name;
        var propertyName = interfaceName[1..];
        var parameterName = char.ToLowerInvariant(propertyName[0]) + propertyName[1..];

        var strBuilder = new StringBuilder();

        strBuilder.AppendLine($"public static class {propertyName}Extensions");
        strBuilder.AppendLine("{");

        foreach (var method in typeByMetadataName.GetMembers().OfType<IMethodSymbol>())
        {
            try
            {
                await AnalyzeAndBuildMethod(method, compilation,strBuilder, typeByMetadataName.ToDisplayString(),
                    parameterName == "path" ? "source" : parameterName,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error processing {method.Name}", ex);
            }
        }

        strBuilder.AppendLine("}");
        
        var result = SyntaxFactory.ParseCompilationUnit(strBuilder.ToString()).NormalizeWhitespace();
        var removeDuplicatesRewriter = new RemoveDuplicatesRewriter();

        await TextCopy.ClipboardService.SetTextAsync(removeDuplicatesRewriter.Visit(result).ToFullString(), cancellationToken);
        AnsiConsole.MarkupLineInterpolated(
            $"[green]Copied extension method abstraction for [bold]{typeByMetadataName.ToDisplayString()}[/] into Clipboard[/]");
    }

    private static async Task AnalyzeAndBuildMethod(IMethodSymbol method, Compilation compilation,
        StringBuilder strBuilder, string interfaceName, string parameterName,
        CancellationToken cancellationToken)
    {
        if (method.DeclaringSyntaxReferences is { Length: <= 0})
        {
            return;
        }
        
        
        if (await method.DeclaringSyntaxReferences[0].GetSyntaxAsync(cancellationToken) is not MethodDeclarationSyntax
            methodSyntax)
        {
            return;
        }

        var methodMetaData = GenerateMethodMetaData(method,compilation, methodSyntax);

        if (!methodMetaData.ShouldBuildMethod())
        {
            return;
        }
            
        var methodBuilder = await BuildMethod(methodMetaData, compilation, interfaceName, parameterName, cancellationToken);
        strBuilder.AppendLine(methodBuilder.ToString());

    }

    private static async Task<StringBuilder> BuildMethod(MethodMetaData metaData, Compilation compilation, string interfaceName, string parameterName, CancellationToken cancellationToken = default)
    {
        if (!metaData.ShouldBuildMethod())
        {
            throw new InvalidOperationException("ShouldBuildMethod should be true");
        }
        
        StringBuilder methodBuilder = new();

        // Removes #end if directives as they are typically the part of the leading trivia and not the
        // trailing triva (it will be added in the bottom if hasElseDirectiveTrivia is true)
        var visitor = new TriviaVisitor();
        
        var trimmedSyntax = visitor.Visit(metaData.MethodSyntax);
        var hasElseDirective = visitor.HasIfDirectiveTrivia;
        
            // Get (e.g., comments, attributes) from the original method and include it in the generated method
            methodBuilder.Append(trimmedSyntax.GetLeadingTrivia().ToFullString());
            methodBuilder.Append(metaData.MethodSyntax.AttributeLists.ToFullString());
            
            // generate the initial signature. For instance public static async <SomeType> or public static void etc.
            methodBuilder.ThenAppend("public static ")
                .AppendIf("async ", metaData.IsAsync || metaData.IsAsyncEnumerable);

            HashSet<string> rewriteParameters = new();
            
            foreach (var parameter in metaData.MethodSymbol.Parameters)
            {
                if (PathMatcher().IsMatch(parameter.Name) && parameter.Type.IsStringLike(compilation))
                {
                    rewriteParameters.Add(parameter.Name);
                }
            }

            var rewriter = new TypeRewriter();
            
            methodBuilder.Append(rewriter
                .Visit(metaData.MethodSyntax.ReturnType)
                .ToString() + " ");

            var parameterRewriter = new ParameterRewriter(rewriteParameters);
            
            // add <MethodName>(this <interfaceName> <parameterName>

            methodBuilder.Append($"{metaData.MethodSymbol.Name} ");
            // wrap in () 
            using (new BuilderWrapper(methodBuilder, b => b.Append("("), b => b.Append(")")))
            {
                methodBuilder.Append($"this {interfaceName} {parameterName}");
                // Enumerate the parameters and generate them. This will test if the name matches path
                foreach (var parameter in metaData.MethodSymbol.Parameters)
                {
                    // if the parameter name match 
                    if (PathMatcher().IsMatch(parameter.Name) && parameter.Type.IsStringLike(compilation) == true)
                    {
                        var node = parameterRewriter.Visit(await parameter.DeclaringSyntaxReferences.First()
                            .GetSyntaxAsync(cancellationToken));
                        methodBuilder.Append($", {node.NormalizeWhitespace()}");
                    }
                    else
                    {
                        methodBuilder.Append($", {parameter.Type.ToDisplayString()} {parameter.Name}");
                    }
                }
            }


            methodBuilder.AppendLine();

            // The code Block for instance:
            //  {
            //      return ...;
            //  }
            using (new BuilderWrapper(methodBuilder, b => b.AppendLine("{"), b => b.AppendLine("}")))
            {
                if (metaData.IsVoid)
                {
                    methodBuilder
                        .AppendIf("await ", metaData.IsAsync)
                        .ThenAppend(await BuildSimpleInvocation())
                        .AppendLine(";");
                }
                else
                {
                    methodBuilder.Append("var result = ")
                        .AppendIf("await ", metaData.IsAsync)
                        .Append(await BuildSimpleInvocation())
                        .AppendLine(";");

                    if (!metaData.ReturnsString)
                    {
                        methodBuilder.Append("return result;");
                    }
                    else
                    {
                        methodBuilder.AppendIf("return ", !metaData.IsAsyncEnumerable);

                        if (metaData.IsEnumerable)
                        {
                            if (metaData.IsAsyncEnumerable)
                            {
                                methodBuilder.AppendLine("await foreach (var se in result)");
                                using (methodBuilder.Block(st => st.AppendLine("{"), en => en.AppendLine("}")))
                                {
                                    methodBuilder.Append("yield return ")
                                        .AppendIf("se.AbsolutePath", metaData.ReturnsNull)
                                        .AppendIf("AbsolutePath.Create(se)", !metaData.ReturnsNull)
                                        .Append(";");
                                }
                            }
                            else
                            {
                                // wrap in [..result.
                                using (methodBuilder.Block(s => s.Append("[.."), s => s.Append(']')))
                                {
                                    methodBuilder
                                        .Append("result")
                                        .AppendIf("?", metaData.ReturnsNull)
                                        .Append(".Select(")
                                        .AppendIf("p =>     p.AsAbsolutePath()", metaData.StringTypeIsNull)
                                        .AppendIf("AbsolutePath.Create", !metaData.StringTypeIsNull)
                                        .Append(")")
                                        .AppendIf("?? []", metaData.ReturnsNull);
                                }    
                            }
                            
                            
                        }
                        else
                        {
                            methodBuilder.AppendIf("result.AsAbsolutePath()", metaData.StringTypeIsNull);
                            methodBuilder.AppendIf("AbsolutePath.Create(result)", !metaData.StringTypeIsNull);
                        }

                        methodBuilder.AppendLine(";");
                    }
                }
            }

            methodBuilder.AppendIf("#endif", hasElseDirective);
            methodBuilder.AppendLine();
            return methodBuilder;
            
            async Task<string> BuildSimpleInvocation()
            {
                var invocation = new StringBuilder();
                // build initial invocation.
                invocation.Append($"{parameterName}.{metaData.MethodSymbol.Name}");

                using (invocation.Block(s => s.Append('('), s => s.Append(')')))
                {

                    foreach (var (index, parameter) in metaData.MethodSymbol.Parameters.Index())
                    {
                        var parameterSyntax = await parameter.DeclaringSyntaxReferences
                            .First()
                            .GetSyntaxAsync(cancellationToken) as ParameterSyntax;

                        // If it is not the first item append a comma
                        if (index > 0)
                        {
                            invocation.Append(",");
                        }

                        if (PathMatcher().IsMatch(parameter.Name))
                        {
                            var isNullable = parameterSyntax?.Type is NullableTypeSyntax;
                            if (isNullable)
                            {
                                invocation.Append($"{parameter.Name}?.Value");
                            }
                            else
                            {
                                invocation.Append($"{parameter.Name}.Value");
                            }
                        }
                        else
                        {
                            invocation.Append(parameter.Name);
                        }
                    }
                }

                return invocation.ToString();
            }


    }

    private static MethodMetaData GenerateMethodMetaData(IMethodSymbol method,
        Compilation compilation,
        MethodDeclarationSyntax methodSyntax)
    {
        var isVoid = method.ReturnsVoid;
        var isTask = method.ReturnType.IsTaskLike(compilation);

        var returnsString = false;
        var isEnumerable = false;

        var returnsNull = false;
        var stringTypeIsNull = false;

        bool isAsyncEnumerable = false;

        void CheckType(ITypeSymbol typeCandidate)
        {
            if (typeCandidate.IsStringLike(compilation) is { IsStringLike: true} stringInfo)
            {
                returnsNull = stringInfo.IsNull;
                stringTypeIsNull = stringInfo.IsNull;
                returnsString = true;
                return;
            }

            if (typeCandidate.TryGetEnumerableElementType(compilation) is { IsEnumerable: true} enumerableInfo)
            {
                returnsNull = method.ReturnNullableAnnotation ==  NullableAnnotation.Annotated;
                if (enumerableInfo.ElementType.IsStringLike(compilation) is {IsStringLike: true} stringLike)
                {
                    returnsString = true;
                    returnsNull = stringLike.IsNull;
                }
                isEnumerable = true;
                isAsyncEnumerable = enumerableInfo.IsAsyncEnumerable;
            }
        }

        if (isTask)
        {
            var namedReturnType = (INamedTypeSymbol) method.ReturnType;

            if (namedReturnType.IsGenericType)
            {
                var type = namedReturnType.TypeArguments[0];

                CheckType(type);
            }
            else
            {
                isVoid = true;
            }
        }
        else
        {
            CheckType(method.ReturnType);
        }

        var hasPathParameter = method.Parameters.Any(x => PathMatcher().IsMatch(x.Name));

        return new MethodMetaData(method, methodSyntax, isTask, isVoid, isEnumerable, returnsString, returnsNull, hasPathParameter, stringTypeIsNull, isAsyncEnumerable);
        
    }
}