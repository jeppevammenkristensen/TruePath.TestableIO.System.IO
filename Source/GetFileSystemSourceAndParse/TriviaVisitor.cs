using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GetFileSystemSourceAndParse;

/// <summary>
/// A syntax rewriter that tracks and removes preprocessor directive trivia (<c>#if</c> / <c>#endif</c>) from syntax nodes.
/// </summary>
public class TriviaVisitor : CSharpSyntaxRewriter
{
    /// <summary>
    /// Initializes a new instance that visits structured trivia.
    /// </summary>
    public TriviaVisitor() : base(true)
    {

    }

    /// <summary>Gets whether an <c>#if</c> directive was encountered during the visit.</summary>
    public bool HasIfDirectiveTrivia { get; private set; }

    /// <summary>Gets the <c>#else</c> directive trivia if one was encountered, otherwise <see langword="null"/>.</summary>
    public ElseDirectiveTriviaSyntax? ElseDirectiveTriviaSyntax { get; private set; }

    /// <inheritdoc />
    public override SyntaxNode? VisitIfDirectiveTrivia(IfDirectiveTriviaSyntax node)
    {
        HasIfDirectiveTrivia = true;
        return base.VisitIfDirectiveTrivia(node);
    }

    /// <inheritdoc />
    public override SyntaxNode? VisitEndIfDirectiveTrivia(EndIfDirectiveTriviaSyntax node)
    {
        return null;
    }

    
}