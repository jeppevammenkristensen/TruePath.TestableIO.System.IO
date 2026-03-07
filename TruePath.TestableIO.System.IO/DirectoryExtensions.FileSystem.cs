using System.Diagnostics.CodeAnalysis;
using TruePath;

namespace System.IO.Abstractions;

public static partial class DirectoryExtensions
{
    /// <inheritdoc cref = "Directory.CreateDirectory(string)"/>
    public static IDirectoryInfo CreateDirectory(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.CreateDirectory(path);
    }

#if FEATURE_FILESYSTEM_UNIXFILEMODE
    /// <inheritdoc cref = "Directory.CreateDirectory(string, UnixFileMode)"/>
    public static IDirectoryInfo CreateDirectory(this AbsolutePath path, UnixFileMode unixCreateMode,
        FileSystem? fileSystem
            = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.CreateDirectory(path, unixCreateMode);
    }
#endif
#if FEATURE_FILESYSTEM_LINK
    /// <inheritdoc cref = "Directory.CreateSymbolicLink(string, string)"/>
    public static IFileSystemInfo DirectoryCreateSymbolicLink(this AbsolutePath path, AbsolutePath pathToTarget, FileSystem?
        fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.CreateSymbolicLink(path, pathToTarget);
    }
#endif

    /// <inheritdoc cref = "Directory.Delete(string)"/>
    public static void Delete(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.Directory.Delete(path);
    }

    /// <inheritdoc cref = "Directory.Delete(string, bool)"/>
    public static void Delete(this AbsolutePath path, bool recursive, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.Directory.Delete(path, recursive);
    }

    /// <inheritdoc cref = "Directory.EnumerateDirectories(string)"/>
    public static IEnumerable<AbsolutePath> EnumerateDirectories(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.EnumerateDirectories(path);
    }

    /// <inheritdoc cref = "Directory.EnumerateDirectories(string, string)"/>
    public static IEnumerable<AbsolutePath> EnumerateDirectories(this AbsolutePath path, string searchPattern,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.EnumerateDirectories(path, searchPattern);
    }

    /// <inheritdoc cref = "Directory.EnumerateDirectories(string, string, SearchOption)"/>
    public static IEnumerable<AbsolutePath> EnumerateDirectories(this AbsolutePath path, string searchPattern,
        SearchOption searchOption, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.EnumerateDirectories(path, searchPattern, searchOption);
    }

#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
    /// <inheritdoc cref = "Directory.EnumerateDirectories(string, string, EnumerationOptions)"/>
    public static IEnumerable<AbsolutePath> EnumerateDirectories(this AbsolutePath path, string searchPattern,
        EnumerationOptions enumerationOptions, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.EnumerateDirectories(path, searchPattern, enumerationOptions);
    }
#endif

    /// <inheritdoc cref = "Directory.EnumerateFiles(string)"/>
    public static IEnumerable<AbsolutePath> EnumerateFiles(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.EnumerateFiles(path);
    }

    /// <inheritdoc cref = "Directory.EnumerateFiles(string, string)"/>
    public static IEnumerable<AbsolutePath> EnumerateFiles(this AbsolutePath path, string searchPattern,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.EnumerateFiles(path, searchPattern);
    }

    /// <inheritdoc cref = "Directory.EnumerateFiles(string, string, SearchOption)"/>
    public static IEnumerable<AbsolutePath> EnumerateFiles(this AbsolutePath path, string searchPattern,
        SearchOption searchOption, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.EnumerateFiles(path, searchPattern, searchOption);
    }

#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
    /// <inheritdoc cref = "Directory.EnumerateFiles(string, string, EnumerationOptions)"/>
    public static IEnumerable<AbsolutePath> EnumerateFiles(this AbsolutePath path, string searchPattern,
        EnumerationOptions enumerationOptions, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.EnumerateFiles(path, searchPattern, enumerationOptions);
    }

#endif

    /// <inheritdoc cref = "Directory.EnumerateFileSystemEntries(string)"/>
    public static IEnumerable<AbsolutePath> EnumerateFileSystemEntries(this AbsolutePath path,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.EnumerateFileSystemEntries(path);
    }

    /// <inheritdoc cref = "Directory.EnumerateFileSystemEntries(string, string)"/>
    public static IEnumerable<AbsolutePath> EnumerateFileSystemEntries(this AbsolutePath path, string searchPattern,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.EnumerateFileSystemEntries(path, searchPattern);
    }

    /// <inheritdoc cref = "Directory.EnumerateFileSystemEntries(string, string, SearchOption)"/>
    public static IEnumerable<AbsolutePath> EnumerateFileSystemEntries(this AbsolutePath path, string searchPattern,
        SearchOption searchOption, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.EnumerateFileSystemEntries(path, searchPattern, searchOption);
    }

#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
    /// <inheritdoc cref = "Directory.EnumerateFileSystemEntries(string, string, EnumerationOptions)"/>
    public static IEnumerable<AbsolutePath> EnumerateFileSystemEntries(this AbsolutePath path, string searchPattern,
        EnumerationOptions enumerationOptions, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.EnumerateFileSystemEntries(path, searchPattern, enumerationOptions);
    }
#endif

    /// <inheritdoc cref = "Directory.Exists(string)"/>
    public static bool DirectoryExists(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.Exists(path);
    }
    
    /// <inheritdoc cref = "Directory.Exists(string)"/>
    public static bool DirectoryExists([NotNullWhen(true)] this AbsolutePath? path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.Exists(path);
    }



    /// <inheritdoc cref = "Directory.GetDirectories(string)"/>
    public static AbsolutePath[] GetDirectories(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.GetDirectories(path);
    }

    /// <inheritdoc cref = "Directory.GetDirectories(string, string)"/>
    public static AbsolutePath[] GetDirectories(this AbsolutePath path, string searchPattern,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.GetDirectories(path, searchPattern);
    }

    /// <inheritdoc cref = "Directory.GetDirectories(string, string, SearchOption)"/>
    public static AbsolutePath[] GetDirectories(this AbsolutePath path, string searchPattern, SearchOption searchOption,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.GetDirectories(path, searchPattern, searchOption);
    }

#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
    /// <inheritdoc cref = "Directory.GetDirectories(string, string, EnumerationOptions)"/>
    public static AbsolutePath[] GetDirectories(this AbsolutePath path, string searchPattern,
        EnumerationOptions enumerationOptions, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.GetDirectories(path, searchPattern, enumerationOptions);
    }
#endif

    /// <inheritdoc cref = "Directory.GetDirectoryRoot(string)"/>
    public static AbsolutePath GetDirectoryRoot(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.GetDirectoryRoot(path);
    }

    /// <inheritdoc cref = "Directory.GetFiles(string)"/>
    public static AbsolutePath[] GetFiles(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.GetFiles(path);
    }

    /// <inheritdoc cref = "Directory.GetFiles(string, string)"/>
    public static AbsolutePath[] GetFiles(this AbsolutePath path, string searchPattern, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.GetFiles(path, searchPattern);
    }

    /// <inheritdoc cref = "Directory.GetFiles(string, string, SearchOption)"/>
    public static AbsolutePath[] GetFiles(this AbsolutePath path, string searchPattern, SearchOption searchOption,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.GetFiles(path, searchPattern, searchOption);
    }

#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
    /// <inheritdoc cref = "Directory.GetFiles(string, string, EnumerationOptions)"/>
    public static AbsolutePath[] GetFiles(this AbsolutePath path, string searchPattern,
        EnumerationOptions enumerationOptions, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.GetFiles(path, searchPattern, enumerationOptions);
    }
#endif

    /// <inheritdoc cref = "Directory.GetFileSystemEntries(string)"/>
    public static AbsolutePath[] GetFileSystemEntries(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.GetFileSystemEntries(path);
    }

    /// <inheritdoc cref = "Directory.GetFileSystemEntries(string, string)"/>
    public static AbsolutePath[] GetFileSystemEntries(this AbsolutePath path, string searchPattern,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.GetFileSystemEntries(path, searchPattern);
    }

    /// <inheritdoc cref = "Directory.GetFileSystemEntries(string, string, SearchOption)"/>
    public static AbsolutePath[] GetFileSystemEntries(this AbsolutePath path, string searchPattern,
        SearchOption searchOption, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.GetFileSystemEntries(path, searchPattern, searchOption);
    }

#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
    /// <inheritdoc cref = "Directory.GetFileSystemEntries(string, string, EnumerationOptions)"/>
    public static AbsolutePath[] GetFileSystemEntries(this AbsolutePath path, string searchPattern,
        EnumerationOptions enumerationOptions, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.GetFileSystemEntries(path, searchPattern, enumerationOptions);
    }
#endif

    /// <inheritdoc cref = "Directory.GetLastAccessTime(string)"/>
    public static DateTime GetLastAccessTime(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.GetLastAccessTime(path);
    }

    /// <inheritdoc cref = "Directory.GetLastAccessTimeUtc(string)"/>
    public static DateTime GetLastAccessTimeUtc(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.GetLastAccessTimeUtc(path);
    }

    /// <inheritdoc cref = "Directory.GetLastWriteTime(string)"/>
    public static DateTime GetLastWriteTime(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.GetLastWriteTime(path);
    }

    /// <inheritdoc cref = "Directory.GetLastWriteTimeUtc(string)"/>
    public static DateTime GetLastWriteTimeUtc(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.GetLastWriteTimeUtc(path);
    }

    /// <inheritdoc cref = "Directory.GetParent(string)"/>
    public static IDirectoryInfo? DirectoryGetParent(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Directory.GetParent(path);
    }

    /// <inheritdoc cref = "Directory.SetCreationTime(string, DateTime)"/>
    public static void DirectorySetCreationTime(this AbsolutePath path, DateTime creationTime, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.Directory.SetCreationTime(path, creationTime);
    }

    /// <inheritdoc cref = "Directory.SetCreationTimeUtc(string, DateTime)"/>
    public static void DirectorySetCreationTimeUtc(this AbsolutePath path, DateTime creationTimeUtc,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.Directory.SetCreationTimeUtc(path, creationTimeUtc);
    }

    /// <inheritdoc cref = "Directory.SetCurrentDirectory(string)"/>
    public static void DirectorySetCurrentDirectory(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.Directory.SetCurrentDirectory(path);
    }

    /// <inheritdoc cref = "Directory.SetLastAccessTime(string, DateTime)"/>
    public static void DirectorySetLastAccessTime(this AbsolutePath path, DateTime lastAccessTime, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.Directory.SetLastAccessTime(path, lastAccessTime);
    }

    /// <inheritdoc cref = "Directory.SetLastAccessTimeUtc(string, DateTime)"/>
    public static void DirectorySetLastAccessTimeUtc(this AbsolutePath path, DateTime lastAccessTimeUtc,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.Directory.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
    }

    /// <inheritdoc cref = "Directory.SetLastWriteTime(string, DateTime)"/>
    public static void DirectorySetLastWriteTime(this AbsolutePath path, DateTime lastWriteTime, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.Directory.SetLastWriteTime(path, lastWriteTime);
    }

    /// <inheritdoc cref = "Directory.SetLastWriteTimeUtc(string, DateTime)"/>
    public static void DirectorySetLastWriteTimeUtc(this AbsolutePath path, DateTime lastWriteTimeUtc,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.Directory.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
    }
}