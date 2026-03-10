using TruePath;

namespace TruePath.System.IO.Abstractions;

internal static class InternalPathExtensions
{
    internal static AbsolutePath? AsAbsolutePath(this string? path)
    {
        return path == null ? null : AbsolutePath.Create(path);
    }
    
    internal static AbsolutePath AsRequired(this string? path)
    {
        return path == null ? throw new InvalidOperationException("Path should not be null") : AbsolutePath.Create(path);
    }
}