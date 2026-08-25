using System.IO.Abstractions;

namespace TruePath.TestableIO.System.IO;

/// <summary>
/// Exposes a factory method for creating <see cref="IFileSystemWatcherFactory"/> instances. If not provided the IFileSystem will resolve to new FileSystem()
/// </summary>
internal static class FileSystemWatcherIOFactory
{
    /// <summary>
    ///     Initializes a new instance of a wrapper for <see cref="FileSystemWatcher" /> which implements
    ///     <see cref="IFileSystemWatcher" />.
    /// </summary>
    /// <param name="path">The directory to monitor, in standard or Universal Naming Convention (UNC) notation.</param>
    /// <param name="fileSystem"></param>
    public static IFileSystemWatcher New(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        var result = fileSystem.FileSystemWatcher.New(path.Value);
        return result;
    }


    /// <summary>
    ///     Initializes a new instance of a wrapper for <see cref="FileSystemWatcher" /> which implements
    ///     <see cref="IFileSystemWatcher" />.
    /// </summary>
    /// <param name="path">The directory to monitor, in standard or Universal Naming Convention (UNC) notation.</param>
    /// <param name="filter">
    ///     The type of files to watch.
    ///     For example, <c>"*.txt"</c> watches for changes to all text files.
    /// </param>
    /// <param name="fileSystem"></param>
    public static IFileSystemWatcher New(AbsolutePath path,
        string filter, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        var result = fileSystem.FileSystemWatcher.New(path.Value, filter);
        return result;
    }
}