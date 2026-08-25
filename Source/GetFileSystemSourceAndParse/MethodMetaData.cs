using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GetFileSystemSourceAndParse;

/// <summary>
/// Wraps meta data about a method
/// </summary>
/// <param name="MethodSymbol">The semantic <see cref="IMethodSymbol"/></param>
/// <param name="MethodSyntax">The <see cref="MethodDeclarationSyntax"/></param>
/// <param name="IsAsync">If the method returns a Task</param>
/// <param name="IsVoid">If the result is void. void or Task</param>
/// <param name="IsEnumerable">If the result is an enumerable (a string is not considered enumerable)</param>
/// <param name="ReturnsString">If the result is a string of a kind. If an enumerable of string is returned. This will also return true</param>
/// <param name="ReturnsNull">If this can return null and the result is some kind of enumerable</param>
/// <param name="HasPathParameter"></param>
public record MethodMetaData(
    IMethodSymbol MethodSymbol,
    MethodDeclarationSyntax MethodSyntax,
    bool IsAsync,
    bool IsVoid,
    bool IsEnumerable,
    bool ReturnsString,
    bool ReturnsNull,
    bool HasPathParameter,
    bool StringTypeIsNull,
    bool IsAsyncEnumerable)
{
    /// <summary>
    /// Determines whether this method should have an extension method generated for it (has a path parameter or returns a string-like type).
    /// </summary>
    public bool ShouldBuildMethod()
    {
        return HasPathParameter || ReturnsString;
    }
}