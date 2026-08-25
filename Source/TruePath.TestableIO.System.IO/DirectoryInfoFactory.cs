using System.IO.Abstractions;

namespace TruePath.TestableIO.System.IO;

/// <summary>
/// Exposes a factory method for creating <see cref="IDirectoryInfo"/> instances. If not provided the IFileSystem will resolve to new FileSystem()
/// </summary>
public static class DirectoryInfoFactory
{
    /// <inheritdoc cref = "DirectoryInfoFactoryExtensions.NewDirectoryInfo(AbsolutePath, IFileSystem? )"/>
    public static IDirectoryInfo New(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.NewDirectoryInfo(fileSystem);
    }
}