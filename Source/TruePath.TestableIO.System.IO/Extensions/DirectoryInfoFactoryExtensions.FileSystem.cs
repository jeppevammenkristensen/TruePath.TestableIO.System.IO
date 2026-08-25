using TruePath;

namespace System.IO.Abstractions;

public static partial class DirectoryInfoFactoryExtensions
{
    /// <inheritdoc cref="IDirectoryInfoFactory.New(string)"/>
    public static IDirectoryInfo NewDirectoryInfo(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.DirectoryInfo.New(path.Value);
    }
}