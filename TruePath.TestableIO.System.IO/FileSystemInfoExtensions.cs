using TruePath;
// ReSharper disable CheckNamespace

namespace System.IO.Abstractions;

/// <summary>
/// Provides extension methods for <see cref="IFileSystemInfo"/> to extend its functionality.
/// </summary>
public static class FileSystemInfoExtensions
{
#if FEATURE_FILESYSTEM_LINK
    /// <inheritdoc cref="FileSystemInfo.CreateAsSymbolicLink(string)" />
    public static void CreateAsSymbolicLink(this IFileSystemInfo fileSystemInfo, AbsolutePath pathToTarget)
    {
        fileSystemInfo.CreateAsSymbolicLink(pathToTarget.Value);
    }
#endif
}


