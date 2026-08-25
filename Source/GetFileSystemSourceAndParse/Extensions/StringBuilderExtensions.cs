using System.Text;

namespace GetFileSystemSourceAndParse.Extensions;

internal static class StringBuilderExtensions
{
    public static IDisposable Block(this StringBuilder builder, Action<StringBuilder> start, Action<StringBuilder> end,
        bool condition = true)
    {
        return new BuilderWrapper(builder, start, end, condition);
    }

    /// <summary>
    /// Chainable appendline. 
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="text"></param>
    /// <returns>the calling builder</returns>
    internal static StringBuilder ThenAppendLine(this StringBuilder builder, string text)
    {
        builder.AppendLine(text);
        return builder;
    }
    
    /// <summary>
    /// Chainable append.
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="text"></param>
    /// <returns></returns>
    internal static StringBuilder ThenAppend(this StringBuilder builder, string text)
    {
        builder.Append(text);
        return builder;
    }
    
    internal static StringBuilder AppendIf(this StringBuilder builder, string text, bool condition)
    {
        if (condition)
        {
            builder.Append(text);
            return builder;
        }
        
        return builder;
    }

    internal static StringBuilder AppendLineIf(this StringBuilder builder, string text, bool condition)
    {
        if (condition)
        {
            builder.AppendLine(text);
        }

        return builder;
    }
}