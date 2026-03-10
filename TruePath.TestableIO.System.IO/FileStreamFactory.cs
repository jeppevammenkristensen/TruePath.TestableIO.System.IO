using System.IO.Abstractions;

namespace TruePath.TestableIO.System.IO;

/// <summary>
/// Exposes a factory method for creating <see cref="IFileInfo"/> instances. If not provided the IFileSystem will resolve to new FileSystem()
/// </summary>
public static class FileStreamFactory
{
    /// <inheritdoc cref="IFileStreamFactory.New(string, FileMode)" />
    public static FileSystemStream New(AbsolutePath path, FileMode mode, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        var result = fileSystem.FileStream.New(path.Value, mode);
        return result;
    }


    /// <inheritdoc cref="IFileStreamFactory.New(string, FileMode, FileAccess)" />
    public static FileSystemStream New(AbsolutePath path, FileMode mode, FileAccess access, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        var result = fileSystem.FileStream.New(path.Value, mode, access);
        return result;
    }


    /// <inheritdoc cref="IFileStreamFactory.New(string, FileMode, FileAccess, FileShare)" />
    public static FileSystemStream New(AbsolutePath path, FileMode mode, FileAccess access, FileShare share, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        var result = fileSystem.FileStream.New(path.Value, mode, access, share);
        return result;
    }


    /// <inheritdoc cref="IFileStreamFactory.New(string, FileMode, FileAccess, FileShare, int)" />
    public static FileSystemStream New(AbsolutePath path, FileMode mode, FileAccess access, FileShare share,
        int bufferSize, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        var result = fileSystem.FileStream.New(path.Value, mode, access, share, bufferSize);
        return result;
    }


    /// <inheritdoc cref="IFileStreamFactory.New(string, FileMode, FileAccess, FileShare, int, bool)" />
    public static FileSystemStream New(AbsolutePath path, FileMode mode, FileAccess access, FileShare share,
        int bufferSize, bool useAsync, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        var result = fileSystem.FileStream.New(path.Value, mode, access, share, bufferSize, useAsync);
        return result;
    }


    /// <inheritdoc cref="IFileStreamFactory.New(string, FileMode, FileAccess, FileShare, int, FileOptions)" />
    public static FileSystemStream New(AbsolutePath path, FileMode mode, FileAccess access, FileShare share,
        int bufferSize, FileOptions options, IFileSystem? fileSystem = null)
    { 
        fileSystem ??= new FileSystem();
        var result = fileSystem.FileStream.New(path.Value, mode, access, share, bufferSize, options);
        return result;
    }


#if FEATURE_FILESYSTEM_STREAM_OPTIONS
    /// <inheritdoc cref="IFileStreamFactory.New(string, FileStreamOptions)" />
    public static FileSystemStream New(AbsolutePath path, FileStreamOptions options, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        var result = fileSystem.FileStream.New(path.Value, options);
        return result;
    }
#endif
}