using TruePath;
// ReSharper disable CheckNamespace

namespace System.IO.Abstractions;

/// <summary>
/// Provides extension methods for the <see cref="IDirectoryInfoFactory"/> type to create
/// <see cref="IDirectoryInfo"/> instances using an <see cref="AbsolutePath"/> parameter.
/// </summary>
public static partial class DirectoryInfoFactoryExtensions
{
    
    /// <inheritdoc cref="IDirectoryInfoFactory.New(string)"/>
    public static IDirectoryInfo New(this IDirectoryInfoFactory directoryInfoFactory,
        AbsolutePath path)
    {
        var result = directoryInfoFactory.New(path.Value);
        return result;
    }

    /// <inheritdoc cref="IDirectoryInfoFactory.New(string)"/>
    public static IDirectoryInfo NewDirectoryInfo(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.DirectoryInfo.New(path.Value);
    }
}




