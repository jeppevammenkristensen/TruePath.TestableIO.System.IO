using System.Diagnostics.CodeAnalysis;
using TruePath;
// ReSharper disable CheckNamespace
namespace System.IO.Abstractions;

// ReSharper disable UnusedMember.Global
/// Provides extension methods for operations on directories <see cref="IDirectory"/>, including creation, deletion, traversal,
/// and retrieving directory-related information.
public static partial class DirectoryExtensions
{
    /// <inheritdoc cref="Directory.CreateDirectory(string)" />
    public static IDirectoryInfo CreateDirectory(this IDirectory directory, AbsolutePath path)
    {
        var result = directory.CreateDirectory(path.Value);
        return result;
    }

#if FEATURE_FILESYSTEM_UNIXFILEMODE
    /// <inheritdoc cref="Directory.CreateDirectory(string, UnixFileMode)" />
    public static IDirectoryInfo CreateDirectory(this IDirectory directory, AbsolutePath path,
        UnixFileMode unixCreateMode)
    {
        var result = directory.CreateDirectory(path.Value, unixCreateMode);
        return result;
    }
#endif


#if FEATURE_FILESYSTEM_LINK
    /// <inheritdoc cref="Directory.CreateSymbolicLink(string, string)" />
    public static IFileSystemInfo CreateSymbolicLink(this IDirectory directory, AbsolutePath path,
        AbsolutePath pathToTarget)
    {
        var result = directory.CreateSymbolicLink(path.Value, pathToTarget.Value);
        return result;
    }
#endif


    /// <inheritdoc cref="Directory.Delete(string)" />
    public static void Delete(this IDirectory directory, AbsolutePath path)
    {
        directory.Delete(path.Value);
    }


    /// <inheritdoc cref="Directory.Delete(string, bool)" />
    public static void Delete(this IDirectory directory, AbsolutePath path, bool recursive)
    {
        directory.Delete(path.Value, recursive);
    }


    /// <inheritdoc cref="Directory.EnumerateDirectories(string)" />
    public static IEnumerable<AbsolutePath> EnumerateDirectories(this IDirectory directory, AbsolutePath path)
    {
        var result = directory.EnumerateDirectories(path.Value);
        return [..result.Select(AbsolutePath.Create)];
    }


    /// <inheritdoc cref="Directory.EnumerateDirectories(string, string)" />
    public static IEnumerable<AbsolutePath> EnumerateDirectories(this IDirectory directory, AbsolutePath path,
        string searchPattern)
    {
        var result = directory.EnumerateDirectories(path.Value, searchPattern);
        return [..result.Select(AbsolutePath.Create)];
    }


    /// <inheritdoc cref="Directory.EnumerateDirectories(string, string, SearchOption)" />
    public static IEnumerable<AbsolutePath> EnumerateDirectories(this IDirectory directory, AbsolutePath path,
        string searchPattern, SearchOption searchOption)
    {
        var result = directory.EnumerateDirectories(path.Value, searchPattern, searchOption);
        return [..result.Select(AbsolutePath.Create)];
    }


#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
    /// <inheritdoc cref="Directory.EnumerateDirectories(string, string, EnumerationOptions)" />
    public static IEnumerable<AbsolutePath> EnumerateDirectories(this IDirectory directory, AbsolutePath path,
        string searchPattern, EnumerationOptions enumerationOptions)
    {
        var result = directory.EnumerateDirectories(path.Value, searchPattern, enumerationOptions);
        return [..result.Select(AbsolutePath.Create)];
    }
#endif


    /// <inheritdoc cref="Directory.EnumerateFiles(string)" />
    public static IEnumerable<AbsolutePath> EnumerateFiles(this IDirectory directory, AbsolutePath path)
    {
        var result = directory.EnumerateFiles(path.Value);
        return [..result.Select(AbsolutePath.Create)];
    }


    /// <inheritdoc cref="Directory.EnumerateFiles(string, string)" />
    public static IEnumerable<AbsolutePath> EnumerateFiles(this IDirectory directory, AbsolutePath path,
        string searchPattern)
    {
        var result = directory.EnumerateFiles(path.Value, searchPattern);
        return [..result.Select(AbsolutePath.Create)];
    }


    /// <inheritdoc cref="Directory.EnumerateFiles(string, string, SearchOption)" />
    public static IEnumerable<AbsolutePath> EnumerateFiles(this IDirectory directory, AbsolutePath path,
        string searchPattern, SearchOption searchOption)
    {
        var result = directory.EnumerateFiles(path.Value, searchPattern, searchOption);
        return [..result.Select(AbsolutePath.Create)];
    }


#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
    /// <inheritdoc cref="Directory.EnumerateFiles(string, string, EnumerationOptions)" />
    public static IEnumerable<AbsolutePath> EnumerateFiles(this IDirectory directory, AbsolutePath path,
        string searchPattern, EnumerationOptions enumerationOptions)
    {
        var result = directory.EnumerateFiles(path.Value, searchPattern, enumerationOptions);
        return [..result.Select(AbsolutePath.Create)];
    }
#endif


    /// <inheritdoc cref="Directory.EnumerateFileSystemEntries(string)" />
    public static IEnumerable<AbsolutePath> EnumerateFileSystemEntries(this IDirectory directory, AbsolutePath path)
    {
        var result = directory.EnumerateFileSystemEntries(path.Value);
        return [..result.Select(AbsolutePath.Create)];
    }


    /// <inheritdoc cref="Directory.EnumerateFileSystemEntries(string, string)" />
    public static IEnumerable<AbsolutePath> EnumerateFileSystemEntries(this IDirectory directory, AbsolutePath path,
        string searchPattern)
    {
        var result = directory.EnumerateFileSystemEntries(path.Value, searchPattern);
        return [..result.Select(AbsolutePath.Create)];
    }


    /// <inheritdoc cref="Directory.EnumerateFileSystemEntries(string, string, SearchOption)" />
    public static IEnumerable<AbsolutePath> EnumerateFileSystemEntries(this IDirectory directory, AbsolutePath path,
        string searchPattern, SearchOption searchOption)
    {
        var result = directory.EnumerateFileSystemEntries(path.Value, searchPattern, searchOption);
        return [..result.Select(AbsolutePath.Create)];
    }


#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
    /// <inheritdoc cref="Directory.EnumerateFileSystemEntries(string, string, EnumerationOptions)" />
    public static IEnumerable<AbsolutePath> EnumerateFileSystemEntries(this IDirectory directory, AbsolutePath path,
        string searchPattern, EnumerationOptions enumerationOptions)
    {
        var result = directory.EnumerateFileSystemEntries(path.Value, searchPattern, enumerationOptions);
        return [..result.Select(AbsolutePath.Create)];
    }
#endif


    /// <inheritdoc cref="Directory.Exists(string)" />
    public static bool Exists(this IDirectory directory, [NotNullWhen(true)] AbsolutePath path)
    {
        var result = directory.Exists(path.Value);
        return result;
    }
    
    /// <inheritdoc cref="Directory.Exists(string)" />
    public static bool Exists(this IDirectory directory, [NotNullWhen(true)] AbsolutePath? path)
    {
        var result = directory.Exists(path?.Value);
        return result;
    }


    /// <inheritdoc cref="Directory.GetCreationTime(string)" />
    public static DateTime GetCreationTime(this IDirectory directory, AbsolutePath path)
    {
        var result = directory.GetCreationTime(path.Value);
        return result;
    }


    /// <inheritdoc cref="Directory.GetCreationTimeUtc(string)" />
    public static DateTime GetCreationTimeUtc(this IDirectory directory, AbsolutePath path)
    {
        var result = directory.GetCreationTimeUtc(path.Value);
        return result;
    }


    /// <inheritdoc cref="Directory.GetCurrentDirectory()" />
    public static AbsolutePath CurrentDirectory(this IDirectory directory)
    {
        var result = directory.GetCurrentDirectory();
        return AbsolutePath.Create(result);
    }


    /// <inheritdoc cref="Directory.GetDirectories(string)" />
    public static AbsolutePath[] GetDirectories(this IDirectory directory, AbsolutePath path)
    {
        var result = directory.GetDirectories(path.Value);
        return [..result.Select(AbsolutePath.Create)];
    }


    /// <inheritdoc cref="Directory.GetDirectories(string, string)" />
    public static AbsolutePath[] GetDirectories(this IDirectory directory, AbsolutePath path, string searchPattern)
    {
        var result = directory.GetDirectories(path.Value, searchPattern);
        return [..result.Select(AbsolutePath.Create)];
    }


    /// <inheritdoc cref="Directory.GetDirectories(string, string, SearchOption)" />
    public static AbsolutePath[] GetDirectories(this IDirectory directory, AbsolutePath path, string searchPattern,
        SearchOption searchOption)
    {
        var result = directory.GetDirectories(path.Value, searchPattern, searchOption);
        return [..result.Select(AbsolutePath.Create)];
    }


#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
    /// <inheritdoc cref="Directory.GetDirectories(string, string, EnumerationOptions)" />
    public static AbsolutePath[] GetDirectories(this IDirectory directory, AbsolutePath path, string searchPattern,
        EnumerationOptions enumerationOptions)
    {
        var result = directory.GetDirectories(path.Value, searchPattern, enumerationOptions);
        return [..result.Select(AbsolutePath.Create)];
    }
#endif


    /// <inheritdoc cref="Directory.GetDirectoryRoot(string)" />
    public static AbsolutePath GetDirectoryRoot(this IDirectory directory, AbsolutePath path)
    {
        var result = directory.GetDirectoryRoot(path.Value);
        return AbsolutePath.Create(result);
    }


    /// <inheritdoc cref="Directory.GetFiles(string)" />
    public static AbsolutePath[] GetFiles(this IDirectory directory, AbsolutePath path)
    {
        var result = directory.GetFiles(path.Value);
        return [..result.Select(AbsolutePath.Create)];
    }


    /// <inheritdoc cref="Directory.GetFiles(string, string)" />
    public static AbsolutePath[] GetFiles(this IDirectory directory, AbsolutePath path, string searchPattern)
    {
        var result = directory.GetFiles(path.Value, searchPattern);
        return [..result.Select(AbsolutePath.Create)];
    }


    /// <inheritdoc cref="Directory.GetFiles(string, string, SearchOption)" />
    public static AbsolutePath[] GetFiles(this IDirectory directory, AbsolutePath path, string searchPattern,
        SearchOption searchOption)
    {
        var result = directory.GetFiles(path.Value, searchPattern, searchOption);
        return [..result.Select(AbsolutePath.Create)];
    }


#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
    /// <inheritdoc cref="Directory.GetFiles(string, string, EnumerationOptions)" />
    public static AbsolutePath[] GetFiles(this IDirectory directory, AbsolutePath path, string searchPattern,
        EnumerationOptions enumerationOptions)
    {
        var result = directory.GetFiles(path.Value, searchPattern, enumerationOptions);
        return [..result.Select(AbsolutePath.Create)];
    }
#endif


    /// <inheritdoc cref="Directory.GetFileSystemEntries(string)" />
    public static AbsolutePath[] GetFileSystemEntries(this IDirectory directory, AbsolutePath path)
    {
        var result = directory.GetFileSystemEntries(path.Value);
        return [..result.Select(AbsolutePath.Create)];
    }


    /// <inheritdoc cref="Directory.GetFileSystemEntries(string, string)" />
    public static AbsolutePath[] GetFileSystemEntries(this IDirectory directory, AbsolutePath path,
        string searchPattern)
    {
        var result = directory.GetFileSystemEntries(path.Value, searchPattern);
        return [..result.Select(AbsolutePath.Create)];
    }


    /// <inheritdoc cref="Directory.GetFileSystemEntries(string, string, SearchOption)" />
    public static AbsolutePath[] GetFileSystemEntries(this IDirectory directory, AbsolutePath path,
        string searchPattern, SearchOption searchOption)
    {
        var result = directory.GetFileSystemEntries(path.Value, searchPattern, searchOption);
        return [..result.Select(AbsolutePath.Create)];
    }


#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
    /// <inheritdoc cref="Directory.GetFileSystemEntries(string, string, EnumerationOptions)" />
    public static AbsolutePath[] GetFileSystemEntries(this IDirectory directory, AbsolutePath path,
        string searchPattern, EnumerationOptions enumerationOptions)
    {
        var result = directory.GetFileSystemEntries(path.Value, searchPattern, enumerationOptions);
        return [..result.Select(AbsolutePath.Create)];
    }
#endif


    /// <inheritdoc cref="Directory.GetLastAccessTime(string)" />
    public static DateTime GetLastAccessTime(this IDirectory directory, AbsolutePath path)
    {
        var result = directory.GetLastAccessTime(path.Value);
        return result;
    }


    /// <inheritdoc cref="Directory.GetLastAccessTimeUtc(string)" />
    public static DateTime GetLastAccessTimeUtc(this IDirectory directory, AbsolutePath path)
    {
        var result = directory.GetLastAccessTimeUtc(path.Value);
        return result;
    }


    /// <inheritdoc cref="Directory.GetLastWriteTime(string)" />
    public static DateTime GetLastWriteTime(this IDirectory directory, AbsolutePath path)
    {
        var result = directory.GetLastWriteTime(path.Value);
        return result;
    }


    /// <inheritdoc cref="Directory.GetLastWriteTimeUtc(string)" />
    public static DateTime GetLastWriteTimeUtc(this IDirectory directory, AbsolutePath path)
    {
        var result = directory.GetLastWriteTimeUtc(path.Value);
        return result;
    }


    /// <inheritdoc cref="Directory.GetLogicalDrives()" />
    public static AbsolutePath[] GetLogicalDrives(this IDirectory directory)
    {
        var result = directory.GetLogicalDrives();
        return [..result.Select(AbsolutePath.Create)];
    }


    /// <inheritdoc cref="Directory.GetParent(string)" />
    public static IDirectoryInfo? GetParent(this IDirectory directory, AbsolutePath path)
    {
        var result = directory.GetParent(path.Value);
        return result;
    }


    /// <inheritdoc cref="Directory.SetCreationTime(string, DateTime)" />
    public static void SetCreationTime(this IDirectory directory, AbsolutePath path, DateTime creationTime)
    {
        directory.SetCreationTime(path.Value, creationTime);
    }


    /// <inheritdoc cref="Directory.SetCreationTimeUtc(string, DateTime)" />
    public static void SetCreationTimeUtc(this IDirectory directory, AbsolutePath path, DateTime creationTimeUtc)
    {
        directory.SetCreationTimeUtc(path.Value, creationTimeUtc);
    }


    /// <inheritdoc cref="Directory.SetCurrentDirectory(string)" />
    public static void SetCurrentDirectory(this IDirectory directory, AbsolutePath path)
    {
        directory.SetCurrentDirectory(path.Value);
    }


    /// <inheritdoc cref="Directory.SetLastAccessTime(string, DateTime)" />
    public static void SetLastAccessTime(this IDirectory directory, AbsolutePath path, DateTime lastAccessTime)
    {
        directory.SetLastAccessTime(path.Value, lastAccessTime);
    }


    /// <inheritdoc cref="Directory.SetLastAccessTimeUtc(string, DateTime)" />
    public static void SetLastAccessTimeUtc(this IDirectory directory, AbsolutePath path, DateTime lastAccessTimeUtc)
    {
        directory.SetLastAccessTimeUtc(path.Value, lastAccessTimeUtc);
    }


    /// <inheritdoc cref="Directory.SetLastWriteTime(string, DateTime)" />
    public static void SetLastWriteTime(this IDirectory directory, AbsolutePath path, DateTime lastWriteTime)
    {
        directory.SetLastWriteTime(path.Value, lastWriteTime);
    }


    /// <inheritdoc cref="Directory.SetLastWriteTimeUtc(string, DateTime)" />
    public static void SetLastWriteTimeUtc(this IDirectory directory, AbsolutePath path, DateTime lastWriteTimeUtc)
    {
        directory.SetLastWriteTimeUtc(path.Value, lastWriteTimeUtc);
    }
}