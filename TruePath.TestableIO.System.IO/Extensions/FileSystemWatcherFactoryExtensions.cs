using TruePath;
// ReSharper disable CheckNamespace
// ReSharper disable InvalidXmlDocComment

namespace System.IO.Abstractions;

/// <summary>
/// Provides extension methods for creating instances of <see cref="IFileSystemWatcher" /> through an
/// <see cref="IFileSystemWatcherFactory" />.
/// </summary>
public static partial class FileSystemWatcherFactoryExtensions
{
    /// <summary>
    ///     Initializes a new instance of a wrapper for <see cref="FileSystemWatcher" /> which implements
    ///     <see cref="IFileSystemWatcher" />.
    /// </summary>
    /// <param name="fileSystemWatcherFactory"></param>
    /// <param name="path">The directory to monitor, in standard or Universal Naming Convention (UNC) notation.</param>
    public static IFileSystemWatcher New(this IFileSystemWatcherFactory fileSystemWatcherFactory, AbsolutePath path)
    {
        var result = fileSystemWatcherFactory.New(path.Value);
        return result;
    }


    /// <summary>
    ///     Initializes a new instance of a wrapper for <see cref="FileSystemWatcher" /> which implements
    ///     <see cref="IFileSystemWatcher" />.
    /// </summary>
    /// <param name="fileSystemWatcherFactory"></param>
    /// <param name="path">The directory to monitor, in standard or Universal Naming Convention (UNC) notation.</param>
    /// <param name="filter">
    ///     The type of files to watch.
    ///     For example, <c>"*.txt"</c> watches for changes to all text files.
    /// </param>
    public static IFileSystemWatcher New(this IFileSystemWatcherFactory fileSystemWatcherFactory, AbsolutePath path,
        string filter)
    {
        var result = fileSystemWatcherFactory.New(path.Value, filter);
        return result;
    }
}