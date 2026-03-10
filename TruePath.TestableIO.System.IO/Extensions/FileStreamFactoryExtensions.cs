using TruePath;
using TruePath.TestableIO.System.IO;

// ReSharper disable CheckNamespace
namespace System.IO.Abstractions;

/// <summary>
/// Provides extension methods for creating <see cref="FileSystemStream"/> instances
/// using the <see cref="IFileStreamFactory"/> interface with the help of
/// <see cref="AbsolutePath"/> objects.
/// </summary>
public static partial class FileStreamFactoryExtensions
{
    /// <inheritdoc cref="IFileStreamFactory.New(string, FileMode)" />
    public static FileSystemStream New(this IFileStreamFactory fileStreamFactory,
        AbsolutePath path, FileMode mode)
    {
        var result = fileStreamFactory.New(path.Value, mode);
        return result;
    }


    /// <inheritdoc cref="IFileStreamFactory.New(string, FileMode, FileAccess)" />
    public static FileSystemStream New(this IFileStreamFactory fileStreamFactory,
        AbsolutePath path, FileMode mode, FileAccess access)
    {
        var result = fileStreamFactory.New(path.Value, mode, access);
        return result;
    }


    /// <inheritdoc cref="IFileStreamFactory.New(string, FileMode, FileAccess, FileShare)" />
    public static FileSystemStream New(this IFileStreamFactory fileStreamFactory,
        AbsolutePath path, FileMode mode, FileAccess access, FileShare share)
    {
        var result = fileStreamFactory.New(path.Value, mode, access, share);
        return result;
    }


    /// <inheritdoc cref="IFileStreamFactory.New(string, FileMode, FileAccess, FileShare, int)" />
    public static FileSystemStream New(this IFileStreamFactory fileStreamFactory,
        AbsolutePath path, FileMode mode, FileAccess access, FileShare share,
        int bufferSize)
    {
        var result = fileStreamFactory.New(path.Value, mode, access, share, bufferSize);
        return result;
    }


    /// <inheritdoc cref="IFileStreamFactory.New(string, FileMode, FileAccess, FileShare, int, bool)" />
    public static FileSystemStream New(this IFileStreamFactory fileStreamFactory,
        AbsolutePath path, FileMode mode, FileAccess access, FileShare share,
        int bufferSize, bool useAsync)
    {
        var result = fileStreamFactory.New(path.Value, mode, access, share, bufferSize, useAsync);
        return result;
    }


    /// <inheritdoc cref="IFileStreamFactory.New(string, FileMode, FileAccess, FileShare, int, FileOptions)" />
    public static FileSystemStream New(this IFileStreamFactory fileStreamFactory,
        AbsolutePath path, FileMode mode, FileAccess access, FileShare share,
        int bufferSize, FileOptions options)
    {
        var result = fileStreamFactory.New(path.Value, mode, access, share, bufferSize, options);
        return result;
    }


#if FEATURE_FILESYSTEM_STREAM_OPTIONS
    /// <inheritdoc cref="IFileStreamFactory.New(string, FileStreamOptions)" />
    public static FileSystemStream New(this IFileStreamFactory fileStreamFactory,
        AbsolutePath path, FileStreamOptions options)
    {
        var result = fileStreamFactory.New(path.Value, options);
        return result;
    }
#endif
}
