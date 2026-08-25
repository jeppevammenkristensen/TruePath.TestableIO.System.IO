using System.Text;

namespace GetFileSystemSourceAndParse;

/// <summary>
/// A disposable wrapper around <see cref="StringBuilder"/> that invokes start/end actions for scoped block generation.
/// </summary>
public class BuilderWrapper : IDisposable
{
    private readonly Action _endAction;

    /// <summary>
    /// Initializes a new <see cref="BuilderWrapper"/>, immediately invoking <paramref name="start"/> if <paramref name="condition"/> is <see langword="true"/>.
    /// </summary>
    public BuilderWrapper(StringBuilder builder, Action<StringBuilder> start, Action<StringBuilder> end, bool condition = true)
    {
        if (condition)
            start(builder);
        _endAction = () =>
        {
            if (condition)
                end(builder);
        };
    }
    
    
    
    /// <inheritdoc />
    public void Dispose()
    {
        _endAction();
    }
}