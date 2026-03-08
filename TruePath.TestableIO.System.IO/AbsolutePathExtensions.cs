using TruePath;

namespace TruePath.System.IO.Abstractions;

internal static class InternalPathExtensions
{
    internal static AbsolutePath? AsAbsolutePath(this string? path)
    {
        return path == null ? null : AbsolutePath.Create(path);
    }
}