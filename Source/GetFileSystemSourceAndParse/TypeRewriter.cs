using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GetFileSystemSourceAndParse;

/// <summary>
/// A syntax rewriter that replaces <see langword="string"/> and <c>ReadOnlySpan&lt;char&gt;</c> type references with <c>AbsolutePath</c>.
/// </summary>
public class TypeRewriter() : CSharpSyntaxRewriter
{
    /// <inheritdoc />
    public override SyntaxNode? VisitPredefinedType(PredefinedTypeSyntax node)
    {
        if (node.Keyword.IsKind(SyntaxKind.StringKeyword))
        {
            return SyntaxFactory.ParseTypeName("AbsolutePath");
        }

        return base.VisitPredefinedType(node);
    }
    
    /// <inheritdoc />
    public override SyntaxNode? VisitGenericName(GenericNameSyntax node)
    {
        // Rewrite ReadOnlySpan<char> (also matches System.ReadOnlySpan<char>, global::System.ReadOnlySpan<char>, etc.)
        if (node.Identifier.Text is "ReadOnlySpan"
            && node.TypeArgumentList.Arguments.Count == 1
            && node.TypeArgumentList.Arguments[0] is PredefinedTypeSyntax { Keyword.RawKind: (int)SyntaxKind.CharKeyword })
        {
            return SyntaxFactory.ParseTypeName("AbsolutePath")
                .WithTriviaFrom(node);
        }

        return base.VisitGenericName(node);
    }
  
}

/// <summary>
/// A syntax rewriter that replaces the type of parameters whose names match the given set with <c>AbsolutePath</c>.
/// </summary>
public class ParameterRewriter(HashSet<string> parameters) : CSharpSyntaxRewriter
{
    /// <inheritdoc />
    public override SyntaxNode? VisitParameter(ParameterSyntax node)
    {
        if (parameters.Contains(node.Identifier.Text))
        {
            var newType = SyntaxFactory.ParseTypeName("AbsolutePath");
            return node.WithType(newType);
        }
        
        return base.VisitParameter(node);
    }
}