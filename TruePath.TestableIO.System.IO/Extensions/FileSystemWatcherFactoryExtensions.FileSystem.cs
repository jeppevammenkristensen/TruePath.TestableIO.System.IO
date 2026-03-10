using TruePath;
using TruePath.TestableIO.System.IO;


namespace System.IO.Abstractions;

public static partial class FileSystemWatcherFactoryExtensions
{    
    /// <summary>
    ///     Initializes a new instance of a wrapper for <see cref="FileSystemWatcher" /> which implements
    ///     <see cref="IFileSystemWatcher" />.
    /// </summary>
    /// <param name="path">The directory to monitor, in standard or Universal Naming Convention (UNC) notation.</param>
    public static IFileSystemWatcher New(this AbsolutePath path) => FileSystemWatcherIOFactory.New(path);
    /// <summary>
    ///     Initializes a new instance of a wrapper for <see cref="FileSystemWatcher" /> which implements
    ///     <see cref="IFileSystemWatcher" />.
    /// </summary>
    /// <param name="path">The directory to monitor, in standard or Universal Naming Convention (UNC) notation.</param>
    /// <param name="filter">
    ///     The type of files to watch.
    ///     For example, <c>"*.txt"</c> watches for changes to all text files.
    /// </param>
    public static IFileSystemWatcher New(this AbsolutePath path, string filter) => FileSystemWatcherIOFactory.New(path,filter);


}