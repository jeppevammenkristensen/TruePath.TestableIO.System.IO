using System.Diagnostics.CodeAnalysis;
using TruePath;

// ReSharper disable CheckNamespace
namespace System.IO.Abstractions;

// ReSharper disable UnusedMember.Global
/// Provides extension methods for operations on directories <see cref="IDirectory"/>, including creation, deletion, traversal,
/// and retrieving directory-related information.
public static partial class DirectoryExtensions
{
    extension(IDirectory directory)
    {
        /// <inheritdoc cref="Directory.CreateDirectory(string)" />
        public IDirectoryInfo CreateDirectory(AbsolutePath path)
        {
            var result = directory.CreateDirectory(path.Value);
            return result;
        }

#if FEATURE_FILESYSTEM_UNIXFILEMODE
        /// <inheritdoc cref="Directory.CreateDirectory(string, UnixFileMode)" />
        public IDirectoryInfo CreateDirectory(AbsolutePath path,
            UnixFileMode unixCreateMode)
        {
            var result = directory.CreateDirectory(path.Value, unixCreateMode);
            return result;
        }
#endif


#if FEATURE_FILESYSTEM_LINK
        /// <inheritdoc cref="Directory.CreateSymbolicLink(string, string)" />
        public IFileSystemInfo CreateSymbolicLink(AbsolutePath path,
            AbsolutePath pathToTarget)
        {
            var result = directory.CreateSymbolicLink(path.Value, pathToTarget.Value);
            return result;
        }
#endif


        /// <inheritdoc cref="Directory.Delete(string)" />
        public void Delete(AbsolutePath path)
        {
            directory.Delete(path.Value);
        }


        /// <inheritdoc cref="Directory.Delete(string, bool)" />
        public void Delete(AbsolutePath path, bool recursive)
        {
            directory.Delete(path.Value, recursive);
        }


        /// <inheritdoc cref="Directory.EnumerateDirectories(string)" />
        public IEnumerable<AbsolutePath> EnumerateDirectories(AbsolutePath path)
        {
            var result = directory.EnumerateDirectories(path.Value);
            return [..result.Select(AbsolutePath.Create)];
        }


        /// <inheritdoc cref="Directory.EnumerateDirectories(string, string)" />
        public IEnumerable<AbsolutePath> EnumerateDirectories(AbsolutePath path,
            string searchPattern)
        {
            var result = directory.EnumerateDirectories(path.Value, searchPattern);
            return [..result.Select(AbsolutePath.Create)];
        }


        /// <inheritdoc cref="Directory.EnumerateDirectories(string, string, SearchOption)" />
        public IEnumerable<AbsolutePath> EnumerateDirectories(AbsolutePath path,
            string searchPattern, SearchOption searchOption)
        {
            var result = directory.EnumerateDirectories(path.Value, searchPattern, searchOption);
            return [..result.Select(AbsolutePath.Create)];
        }


#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
        /// <inheritdoc cref="Directory.EnumerateDirectories(string, string, EnumerationOptions)" />
        public IEnumerable<AbsolutePath> EnumerateDirectories(AbsolutePath path,
            string searchPattern, EnumerationOptions enumerationOptions)
        {
            var result = directory.EnumerateDirectories(path.Value, searchPattern, enumerationOptions);
            return [..result.Select(AbsolutePath.Create)];
        }
#endif


        /// <inheritdoc cref="Directory.EnumerateFiles(string)" />
        public IEnumerable<AbsolutePath> EnumerateFiles(AbsolutePath path)
        {
            var result = directory.EnumerateFiles(path.Value);
            return [..result.Select(AbsolutePath.Create)];
        }


        /// <inheritdoc cref="Directory.EnumerateFiles(string, string)" />
        public IEnumerable<AbsolutePath> EnumerateFiles(AbsolutePath path,
            string searchPattern)
        {
            var result = directory.EnumerateFiles(path.Value, searchPattern);
            return [..result.Select(AbsolutePath.Create)];
        }


        /// <inheritdoc cref="Directory.EnumerateFiles(string, string, SearchOption)" />
        public IEnumerable<AbsolutePath> EnumerateFiles(AbsolutePath path,
            string searchPattern, SearchOption searchOption)
        {
            var result = directory.EnumerateFiles(path.Value, searchPattern, searchOption);
            return [..result.Select(AbsolutePath.Create)];
        }


#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
        /// <inheritdoc cref="Directory.EnumerateFiles(string, string, EnumerationOptions)" />
        public IEnumerable<AbsolutePath> EnumerateFiles(AbsolutePath path,
            string searchPattern, EnumerationOptions enumerationOptions)
        {
            var result = directory.EnumerateFiles(path.Value, searchPattern, enumerationOptions);
            return [..result.Select(AbsolutePath.Create)];
        }
#endif


        /// <inheritdoc cref="Directory.EnumerateFileSystemEntries(string)" />
        public IEnumerable<AbsolutePath> EnumerateFileSystemEntries(AbsolutePath path)
        {
            var result = directory.EnumerateFileSystemEntries(path.Value);
            return [..result.Select(AbsolutePath.Create)];
        }


        /// <inheritdoc cref="Directory.EnumerateFileSystemEntries(string, string)" />
        public IEnumerable<AbsolutePath> EnumerateFileSystemEntries(AbsolutePath path,
            string searchPattern)
        {
            var result = directory.EnumerateFileSystemEntries(path.Value, searchPattern);
            return [..result.Select(AbsolutePath.Create)];
        }


        /// <inheritdoc cref="Directory.EnumerateFileSystemEntries(string, string, SearchOption)" />
        public IEnumerable<AbsolutePath> EnumerateFileSystemEntries(AbsolutePath path,
            string searchPattern, SearchOption searchOption)
        {
            var result = directory.EnumerateFileSystemEntries(path.Value, searchPattern, searchOption);
            return [..result.Select(AbsolutePath.Create)];
        }


#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
        /// <inheritdoc cref="Directory.EnumerateFileSystemEntries(string, string, EnumerationOptions)" />
        public IEnumerable<AbsolutePath> EnumerateFileSystemEntries(AbsolutePath path,
            string searchPattern, EnumerationOptions enumerationOptions)
        {
            var result = directory.EnumerateFileSystemEntries(path.Value, searchPattern, enumerationOptions);
            return [..result.Select(AbsolutePath.Create)];
        }
#endif


        /// <inheritdoc cref="Directory.Exists(string)" />
        public bool Exists(AbsolutePath path)
        {
            var result = directory.Exists(path.Value);
            return result;
        }

        /// <inheritdoc cref="Directory.Exists(string)" />
        public bool Exists([NotNullWhen(true)] AbsolutePath? path)
        {
            var result = directory.Exists(path?.Value);
            return result;
        }


        /// <inheritdoc cref="Directory.GetCreationTime(string)" />
        public DateTime GetCreationTime(AbsolutePath path)
        {
            var result = directory.GetCreationTime(path.Value);
            return result;
        }


        /// <inheritdoc cref="Directory.GetCreationTimeUtc(string)" />
        public DateTime GetCreationTimeUtc(AbsolutePath path)
        {
            var result = directory.GetCreationTimeUtc(path.Value);
            return result;
        }


        /// <inheritdoc cref="Directory.GetCurrentDirectory()" />
        public AbsolutePath CurrentDirectory()
        {
            var result = directory.GetCurrentDirectory();
            return AbsolutePath.Create(result);
        }


        /// <inheritdoc cref="Directory.GetDirectories(string)" />
        public AbsolutePath[] GetDirectories(AbsolutePath path)
        {
            var result = directory.GetDirectories(path.Value);
            return [..result.Select(AbsolutePath.Create)];
        }


        /// <inheritdoc cref="Directory.GetDirectories(string, string)" />
        public AbsolutePath[] GetDirectories(AbsolutePath path, string searchPattern)
        {
            var result = directory.GetDirectories(path.Value, searchPattern);
            return [..result.Select(AbsolutePath.Create)];
        }


        /// <inheritdoc cref="Directory.GetDirectories(string, string, SearchOption)" />
        public AbsolutePath[] GetDirectories(AbsolutePath path, string searchPattern,
            SearchOption searchOption)
        {
            var result = directory.GetDirectories(path.Value, searchPattern, searchOption);
            return [..result.Select(AbsolutePath.Create)];
        }


#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
        /// <inheritdoc cref="Directory.GetDirectories(string, string, EnumerationOptions)" />
        public AbsolutePath[] GetDirectories(AbsolutePath path, string searchPattern,
            EnumerationOptions enumerationOptions)
        {
            var result = directory.GetDirectories(path.Value, searchPattern, enumerationOptions);
            return [..result.Select(AbsolutePath.Create)];
        }
#endif


        /// <inheritdoc cref="Directory.GetDirectoryRoot(string)" />
        public AbsolutePath GetDirectoryRoot(AbsolutePath path)
        {
            var result = directory.GetDirectoryRoot(path.Value);
            return AbsolutePath.Create(result);
        }


        /// <inheritdoc cref="Directory.GetFiles(string)" />
        public AbsolutePath[] GetFiles(AbsolutePath path)
        {
            var result = directory.GetFiles(path.Value);
            return [..result.Select(AbsolutePath.Create)];
        }


        /// <inheritdoc cref="Directory.GetFiles(string, string)" />
        public AbsolutePath[] GetFiles(AbsolutePath path, string searchPattern)
        {
            var result = directory.GetFiles(path.Value, searchPattern);
            return [..result.Select(AbsolutePath.Create)];
        }


        /// <inheritdoc cref="Directory.GetFiles(string, string, SearchOption)" />
        public AbsolutePath[] GetFiles(AbsolutePath path, string searchPattern,
            SearchOption searchOption)
        {
            var result = directory.GetFiles(path.Value, searchPattern, searchOption);
            return [..result.Select(AbsolutePath.Create)];
        }


#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
        /// <inheritdoc cref="Directory.GetFiles(string, string, EnumerationOptions)" />
        public AbsolutePath[] GetFiles(AbsolutePath path, string searchPattern,
            EnumerationOptions enumerationOptions)
        {
            var result = directory.GetFiles(path.Value, searchPattern, enumerationOptions);
            return [..result.Select(AbsolutePath.Create)];
        }
#endif


        /// <inheritdoc cref="Directory.GetFileSystemEntries(string)" />
        public AbsolutePath[] GetFileSystemEntries(AbsolutePath path)
        {
            var result = directory.GetFileSystemEntries(path.Value);
            return [..result.Select(AbsolutePath.Create)];
        }


        /// <inheritdoc cref="Directory.GetFileSystemEntries(string, string)" />
        public AbsolutePath[] GetFileSystemEntries(AbsolutePath path,
            string searchPattern)
        {
            var result = directory.GetFileSystemEntries(path.Value, searchPattern);
            return [..result.Select(AbsolutePath.Create)];
        }


        /// <inheritdoc cref="Directory.GetFileSystemEntries(string, string, SearchOption)" />
        public AbsolutePath[] GetFileSystemEntries(AbsolutePath path,
            string searchPattern, SearchOption searchOption)
        {
            var result = directory.GetFileSystemEntries(path.Value, searchPattern, searchOption);
            return [..result.Select(AbsolutePath.Create)];
        }


#if FEATURE_FILESYSTEM_ENUMERATION_OPTIONS
        /// <inheritdoc cref="Directory.GetFileSystemEntries(string, string, EnumerationOptions)" />
        public AbsolutePath[] GetFileSystemEntries(AbsolutePath path,
            string searchPattern, EnumerationOptions enumerationOptions)
        {
            var result = directory.GetFileSystemEntries(path.Value, searchPattern, enumerationOptions);
            return [..result.Select(AbsolutePath.Create)];
        }
#endif


        /// <inheritdoc cref="Directory.GetLastAccessTime(string)" />
        public DateTime GetLastAccessTime(AbsolutePath path)
        {
            var result = directory.GetLastAccessTime(path.Value);
            return result;
        }


        /// <inheritdoc cref="Directory.GetLastAccessTimeUtc(string)" />
        public DateTime GetLastAccessTimeUtc(AbsolutePath path)
        {
            var result = directory.GetLastAccessTimeUtc(path.Value);
            return result;
        }


        /// <inheritdoc cref="Directory.GetLastWriteTime(string)" />
        public DateTime GetLastWriteTime(AbsolutePath path)
        {
            var result = directory.GetLastWriteTime(path.Value);
            return result;
        }


        /// <inheritdoc cref="Directory.GetLastWriteTimeUtc(string)" />
        public DateTime GetLastWriteTimeUtc(AbsolutePath path)
        {
            var result = directory.GetLastWriteTimeUtc(path.Value);
            return result;
        }


        /// <inheritdoc cref="Directory.GetLogicalDrives()" />
        public AbsolutePath[] GetLogicalDrives()
        {
            var result = directory.GetLogicalDrives();
            return [..result.Select(AbsolutePath.Create)];
        }


        /// <inheritdoc cref="Directory.GetParent(string)" />
        public IDirectoryInfo? GetParent(AbsolutePath path)
        {
            var result = directory.GetParent(path.Value);
            return result;
        }


        /// <inheritdoc cref="Directory.SetCreationTime(string, DateTime)" />
        public void SetCreationTime(AbsolutePath path, DateTime creationTime)
        {
            directory.SetCreationTime(path.Value, creationTime);
        }


        /// <inheritdoc cref="Directory.SetCreationTimeUtc(string, DateTime)" />
        public void SetCreationTimeUtc(AbsolutePath path, DateTime creationTimeUtc)
        {
            directory.SetCreationTimeUtc(path.Value, creationTimeUtc);
        }


        /// <inheritdoc cref="Directory.SetCurrentDirectory(string)" />
        public void SetCurrentDirectory(AbsolutePath path)
        {
            directory.SetCurrentDirectory(path.Value);
        }


        /// <inheritdoc cref="Directory.SetLastAccessTime(string, DateTime)" />
        public void SetLastAccessTime(AbsolutePath path, DateTime lastAccessTime)
        {
            directory.SetLastAccessTime(path.Value, lastAccessTime);
        }


        /// <inheritdoc cref="Directory.SetLastAccessTimeUtc(string, DateTime)" />
        public void SetLastAccessTimeUtc(AbsolutePath path, DateTime lastAccessTimeUtc)
        {
            directory.SetLastAccessTimeUtc(path.Value, lastAccessTimeUtc);
        }


        /// <inheritdoc cref="Directory.SetLastWriteTime(string, DateTime)" />
        public void SetLastWriteTime(AbsolutePath path, DateTime lastWriteTime)
        {
            directory.SetLastWriteTime(path.Value, lastWriteTime);
        }


        /// <inheritdoc cref="Directory.SetLastWriteTimeUtc(string, DateTime)" />
        public void SetLastWriteTimeUtc(AbsolutePath path, DateTime lastWriteTimeUtc)
        {
            directory.SetLastWriteTimeUtc(path.Value, lastWriteTimeUtc);
        }

        /// <inheritdoc cref="Directory.Move(string, string)" />
        public void Move(AbsolutePath sourceDirName, AbsolutePath destDirName)
        {
            directory.Move(sourceDirName.Value, destDirName.Value);
        }
    }
}