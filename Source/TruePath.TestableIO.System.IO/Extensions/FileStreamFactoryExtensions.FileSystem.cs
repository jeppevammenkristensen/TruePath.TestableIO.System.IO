using TruePath;
using TruePath.TestableIO.System.IO;

namespace System.IO.Abstractions;

public static partial class FileStreamFactoryExtensions
{
    /// <inheritdoc cref="IFileStreamFactory.New(string, FileMode)" />
    public static FileSystemStream New(this AbsolutePath path, FileMode mode) => FileStreamFactory.New(path, mode);
    
    /// <inheritdoc cref="IFileStreamFactory.New(string, FileMode, FileAccess)" />
    public static FileSystemStream New(AbsolutePath path, FileMode mode, FileAccess access) => FileStreamFactory.New(path, mode, access);


    /// <inheritdoc cref="IFileStreamFactory.New(string, FileMode, FileAccess, FileShare)" />
    public static FileSystemStream New(AbsolutePath path, FileMode mode, FileAccess access, FileShare share) => FileStreamFactory.New(path, mode, access, share);


    /// <inheritdoc cref="IFileStreamFactory.New(string, FileMode, FileAccess, FileShare, int)" />
    public static FileSystemStream New(AbsolutePath path, FileMode mode, FileAccess access, FileShare share,
        int bufferSize) => FileStreamFactory.New(path, mode, access, share, bufferSize);

    /// <inheritdoc cref="IFileStreamFactory.New(string, FileMode, FileAccess, FileShare, int, bool)" />
    public static FileSystemStream New(AbsolutePath path, FileMode mode, FileAccess access, FileShare share,
        int bufferSize, bool useAsync) => FileStreamFactory.New(path, mode, access, share, bufferSize, useAsync);

    /// <inheritdoc cref="IFileStreamFactory.New(string, FileMode, FileAccess, FileShare, int, FileOptions)" />
    public static FileSystemStream New(AbsolutePath path, FileMode mode, FileAccess access, FileShare share,
        int bufferSize, FileOptions options) => FileStreamFactory.New(path, mode, access, share, bufferSize, options);

#if FEATURE_FILESYSTEM_STREAM_OPTIONS
    /// <inheritdoc cref="IFileStreamFactory.New(string, FileStreamOptions)" />
    public static FileSystemStream New(AbsolutePath path, FileStreamOptions options) => FileStreamFactory.New(path, options);
#endif
}