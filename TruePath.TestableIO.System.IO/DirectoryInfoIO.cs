using System.IO.Abstractions;

namespace TruePath.TestableIO.System.IO;

public static class DirectoryInfoIO
{
    
    /// <inheritdoc cref = "DirectoryInfoFactoryExtensions.NewDirectoryInfo(AbsolutePath, IFileSystem? )"/>
    public static IDirectoryInfo NewDirectoryInfo(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.NewDirectoryInfo(fileSystem);
    }

}