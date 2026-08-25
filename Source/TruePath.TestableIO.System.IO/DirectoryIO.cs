using System.Diagnostics.CodeAnalysis;
using System.IO.Abstractions;

namespace TruePath.TestableIO.System.IO;

/// <summary>
/// Add direct methods to <see cref="IDirectory"/> convenience methods. The methods will conditionally accept a <see cref="IFileSystem"/>
/// which if not defined will default to <![CDATA[new FileSystem()]]> 
/// </summary>
public static class DirectoryIO
{
    /// <inheritdoc cref = "DirectoryExtensions.CreateDirectory(AbsolutePath, IFileSystem?)"/>
    public static IDirectoryInfo CreateDirectory(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.CreateDirectory(fileSystem);
    }

#if FEATURE_FILESYSTEM_UNIXFILEMODE
    /// <inheritdoc cref = "DirectoryExtensions.CreateDirectory(AbsolutePath, UnixFileMode, IFileSystem)"/>
    public static IDirectoryInfo CreateDirectory(AbsolutePath path, UnixFileMode unixCreateMode, IFileSystem? fileSystem = null)
    {
        return path.CreateDirectory(unixCreateMode, fileSystem);
    }
#endif
#if FEATURE_FILESYSTEM_LINK
    /// <inheritdoc cref = "DirectoryExtensions.DirectoryCreateSymbolicLink(AbsolutePath, AbsolutePath, IFileSystem?)"/>
    public static IFileSystemInfo CreateSymbolicLink(AbsolutePath path, AbsolutePath pathToTarget, IFileSystem? fileSystem = null)
    {
        return path.DirectoryCreateSymbolicLink(pathToTarget, fileSystem);
    }
#endif

    /// <inheritdoc cref = "DirectoryExtensions.DirectoryDelete(AbsolutePath, IFileSystem?)"/>
    public static void Delete(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        path.DirectoryDelete(fileSystem);
    }

    /// <inheritdoc cref = "DirectoryExtensions.DirectoryDelete(AbsolutePath, bool, IFileSystem? )"/>
    public static void Delete(AbsolutePath path, bool recursive, IFileSystem? fileSystem = null)
    {
        path.DirectoryDelete(recursive, fileSystem);
    }

    /// <inheritdoc cref = "DirectoryExtensions.EnumerateDirectories(AbsolutePath, IFileSystem? )"/>
    public static IEnumerable<AbsolutePath> EnumerateDirectories(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.EnumerateDirectories(fileSystem);
    }

    /// <inheritdoc cref = "DirectoryExtensions.EnumerateDirectories(AbsolutePath, string, IFileSystem? )"/>
    public static IEnumerable<AbsolutePath> EnumerateDirectories(AbsolutePath path, string searchPattern, IFileSystem? fileSystem = null)
    {
        return path.EnumerateDirectories(searchPattern, fileSystem);
    }
    
    /// <inheritdoc cref = "DirectoryExtensions.EnumerateDirectories(AbsolutePath, string, SearchOption, IFileSystem? )"/>
    public static IEnumerable<AbsolutePath> EnumerateDirectories(AbsolutePath path, string searchPattern, SearchOption searchOption, IFileSystem? fileSystem = null)
    {
        return path.EnumerateDirectories(searchPattern, searchOption, fileSystem);
    }
#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
    /// <inheritdoc cref = "DirectoryExtensions.EnumerateDirectories(AbsolutePath, string, EnumerationOptions, IFileSystem? )"/>
    public static IEnumerable<AbsolutePath> EnumerateDirectories(AbsolutePath path, string searchPattern, EnumerationOptions enumerationOptions, IFileSystem? fileSystem = null)
    {
        return path.EnumerateDirectories(searchPattern, enumerationOptions, fileSystem);
    }
#endif

    /// <inheritdoc cref = "DirectoryExtensions.EnumerateFiles(AbsolutePath, IFileSystem? )"/>
    public static IEnumerable<AbsolutePath> EnumerateFiles(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.EnumerateFiles(fileSystem);
    }
  
    /// <inheritdoc cref = "DirectoryExtensions.EnumerateFiles(AbsolutePath, string, IFileSystem? )"/>
    public static IEnumerable<AbsolutePath> EnumerateFiles(AbsolutePath path, string searchPattern, IFileSystem? fileSystem = null)
    {
        return path.EnumerateFiles(searchPattern, fileSystem);
    }

    /// <inheritdoc cref = "DirectoryExtensions.EnumerateFiles(AbsolutePath, string, SearchOption, IFileSystem? )"/>
    public static IEnumerable<AbsolutePath> EnumerateFiles(AbsolutePath path, string searchPattern, SearchOption searchOption, IFileSystem? fileSystem = null)
    {
        return path.EnumerateFiles(searchPattern, searchOption, fileSystem);
    }

#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
    /// <inheritdoc cref = "DirectoryExtensions.EnumerateFiles(AbsolutePath, string, EnumerationOptions, IFileSystem? )"/>
    public static IEnumerable<AbsolutePath> EnumerateFiles(AbsolutePath path, string searchPattern, EnumerationOptions enumerationOptions, IFileSystem? fileSystem = null)
    {
        return path.EnumerateFiles(searchPattern, enumerationOptions, fileSystem);
    }

#endif

    /// <inheritdoc cref = "DirectoryExtensions.EnumerateFileSystemEntries(AbsolutePath, string, SearchOption, IFileSystem? )"/>
    public static IEnumerable<AbsolutePath> EnumerateFileSystemEntries(AbsolutePath path, string searchPattern, SearchOption searchOption, IFileSystem? fileSystem = null)
    {
        return path.EnumerateFileSystemEntries(searchPattern, searchOption, fileSystem);
    }

#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
    /// <inheritdoc cref = "DirectoryExtensions.EnumerateFileSystemEntries(AbsolutePath, string, EnumerationOptions, IFileSystem? )"/>
    public static IEnumerable<AbsolutePath> EnumerateFileSystemEntries(AbsolutePath path, string searchPattern, EnumerationOptions enumerationOptions, IFileSystem? fileSystem = null)
    {
        return path.EnumerateFileSystemEntries(searchPattern, enumerationOptions, fileSystem);
    }
#endif

    /// <inheritdoc cref = "DirectoryExtensions.DirectoryExists(AbsolutePath, IFileSystem? )"/>
    public static bool Exists(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.DirectoryExists(fileSystem);
    }
    /// <inheritdoc cref = "DirectoryExtensions.DirectoryExists(AbsolutePath? , IFileSystem? )"/>
    public static bool Exists([NotNullWhen(true)] AbsolutePath? path, IFileSystem? fileSystem = null)
    {
        return path.DirectoryExists(fileSystem);
    }



    /// <inheritdoc cref = "DirectoryExtensions.GetDirectories(AbsolutePath, IFileSystem? )"/>
    public static AbsolutePath[] GetDirectories(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.GetDirectories(fileSystem);
    }
    /// <inheritdoc cref = "DirectoryExtensions.GetDirectories(AbsolutePath, string, IFileSystem? )"/>
    public static AbsolutePath[] GetDirectories(AbsolutePath path, string searchPattern, IFileSystem? fileSystem = null)
    {
        return path.GetDirectories(searchPattern, fileSystem);
    }
    /// <inheritdoc cref = "DirectoryExtensions.GetDirectories(AbsolutePath, string, SearchOption, IFileSystem? )"/>
    public static AbsolutePath[] GetDirectories(AbsolutePath path, string searchPattern, SearchOption searchOption, IFileSystem? fileSystem = null)
    {
        return path.GetDirectories(searchPattern, searchOption, fileSystem);
    }

#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
    /// <inheritdoc cref = "DirectoryExtensions.GetDirectories(AbsolutePath, string, EnumerationOptions, IFileSystem? )"/>
    public static AbsolutePath[] GetDirectories(AbsolutePath path, string searchPattern, EnumerationOptions enumerationOptions, IFileSystem? fileSystem = null)
    {
        return path.GetDirectories(searchPattern, enumerationOptions, fileSystem);
    }
#endif

    /// <inheritdoc cref = "DirectoryExtensions.GetDirectoryRoot(AbsolutePath, IFileSystem? )"/>
    public static AbsolutePath GetDirectoryRoot(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.GetDirectoryRoot(fileSystem);
    }

    /// <inheritdoc cref = "DirectoryExtensions.GetFiles(AbsolutePath, IFileSystem? )"/>
    public static AbsolutePath[] GetFiles(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.GetFiles(fileSystem);
    }
    /// <inheritdoc cref = "DirectoryExtensions.GetFiles(AbsolutePath, string, IFileSystem? )"/>
    public static AbsolutePath[] GetFiles(AbsolutePath path, string searchPattern, IFileSystem? fileSystem = null)
    {
        return path.GetFiles(searchPattern, fileSystem);
    }
    /// <inheritdoc cref = "DirectoryExtensions.GetFiles(AbsolutePath, string, SearchOption, IFileSystem? )"/>
    public static AbsolutePath[] GetFiles(AbsolutePath path, string searchPattern, SearchOption searchOption, IFileSystem? fileSystem = null)
    {
        return path.GetFiles(searchPattern, searchOption, fileSystem);
    }

#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
    /// <inheritdoc cref = "DirectoryExtensions.GetFiles(AbsolutePath, string, EnumerationOptions, IFileSystem? )"/>
    public static AbsolutePath[] GetFiles(AbsolutePath path, string searchPattern, EnumerationOptions enumerationOptions, IFileSystem? fileSystem = null)
    {
        return path.GetFiles(searchPattern, enumerationOptions, fileSystem);
    }
#endif

    /// <inheritdoc cref = "DirectoryExtensions.GetFileSystemEntries(AbsolutePath, string, SearchOption, IFileSystem? )"/>
    public static AbsolutePath[] GetFileSystemEntries(AbsolutePath path, string searchPattern, SearchOption searchOption, IFileSystem? fileSystem = null)
    {
        return path.GetFileSystemEntries(searchPattern, searchOption, fileSystem);
    }

#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
    /// <inheritdoc cref = "DirectoryExtensions.GetFileSystemEntries(AbsolutePath, string, EnumerationOptions, IFileSystem? )"/>
    public static AbsolutePath[] GetFileSystemEntries(AbsolutePath path, string searchPattern, EnumerationOptions enumerationOptions, IFileSystem? fileSystem = null)
    {
        return path.GetFileSystemEntries(searchPattern, enumerationOptions, fileSystem);
    }
#endif

    /// <inheritdoc cref = "DirectoryExtensions.GetLastWriteTimeUtc(AbsolutePath, IFileSystem? )"/>
    public static DateTime GetLastWriteTimeUtc(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.GetLastWriteTimeUtc(fileSystem);
    }

    /// <inheritdoc cref = "DirectoryExtensions.DirectoryGetParent(AbsolutePath, IFileSystem? )"/>
    public static IDirectoryInfo? GetParent(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.DirectoryGetParent(fileSystem);
    }

    /// <inheritdoc cref = "DirectoryExtensions.DirectorySetCreationTime(AbsolutePath, DateTime, IFileSystem? )"/>
    public static void SetCreationTime(AbsolutePath path, DateTime creationTime, IFileSystem? fileSystem = null)
    {
        path.DirectorySetCreationTime(creationTime, fileSystem);
    }
    /// <inheritdoc cref = "DirectoryExtensions.DirectorySetCreationTimeUtc(AbsolutePath, DateTime, IFileSystem? )"/>
    public static void SetCreationTimeUtc(AbsolutePath path, DateTime creationTimeUtc, IFileSystem? fileSystem = null)
    {
        path.DirectorySetCreationTimeUtc(creationTimeUtc, fileSystem);
    }

    /// <inheritdoc cref = "DirectoryExtensions.DirectorySetCurrentDirectory(AbsolutePath, IFileSystem? )"/>
    public static void SetCurrentDirectory(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        path.DirectorySetCurrentDirectory(fileSystem);
    }

    /// <inheritdoc cref = "DirectoryExtensions.DirectorySetLastAccessTime(AbsolutePath, DateTime, IFileSystem? )"/>
    public static void SetLastAccessTime(AbsolutePath path, DateTime lastAccessTime, IFileSystem? fileSystem = null)
    {
        path.DirectorySetLastAccessTime(lastAccessTime, fileSystem);
    }

    /// <inheritdoc cref = "DirectoryExtensions.DirectorySetLastAccessTimeUtc(AbsolutePath, DateTime, IFileSystem? )"/>
    public static void SetLastAccessTimeUtc(AbsolutePath path, DateTime lastAccessTimeUtc, IFileSystem? fileSystem = null)
    {
        path.DirectorySetLastAccessTimeUtc(lastAccessTimeUtc, fileSystem);
    }

   /// <inheritdoc cref = "DirectoryExtensions.DirectorySetLastWriteTime(AbsolutePath, DateTime, IFileSystem? )"/>
    public static void SetLastWriteTime(AbsolutePath path, DateTime lastWriteTime, IFileSystem? fileSystem = null)
    {
        path.DirectorySetLastAccessTime(lastWriteTime, fileSystem);
    }   
}