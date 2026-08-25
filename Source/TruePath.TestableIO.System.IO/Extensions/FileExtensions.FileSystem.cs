using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using System.Text;
using TruePath;

namespace System.IO.Abstractions;

public static partial class FileExtensions
{
#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.AppendAllBytes(string, byte[])"/>
    public static void AppendAllBytes(this AbsolutePath path, byte[] bytes, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.AppendAllBytes(path, bytes);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.AppendAllBytes(string, ReadOnlySpan{byte})"/>
    public static void AppendAllBytes(this AbsolutePath path, ReadOnlySpan<byte> bytes, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.AppendAllBytes(path, bytes);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.AppendAllBytesAsync(string, byte[], CancellationToken)"/>
    public static Task AppendAllBytesAsync(this AbsolutePath path, byte[] bytes, CancellationToken cancellationToken,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.AppendAllBytesAsync(path, bytes, cancellationToken);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.AppendAllBytesAsync(string, ReadOnlyMemory{byte}, CancellationToken)"/>
    public static Task AppendAllBytesAsync(this AbsolutePath path, ReadOnlyMemory<byte> bytes,
        CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.AppendAllBytesAsync(path, bytes, cancellationToken);
    }
#endif


    /// <inheritdoc cref = "File.AppendAllLines(string, IEnumerable{string})"/>
    public static void AppendAllLines(this AbsolutePath path, IEnumerable<string> contents,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.AppendAllLines(path, contents);
    }

    /// <inheritdoc cref = "File.AppendAllLines(string, IEnumerable{string}, Encoding)"/>
    public static void AppendAllLines(this AbsolutePath path, IEnumerable<string> contents, Encoding encoding,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.AppendAllLines(path, contents, encoding);
    }

#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.AppendAllLinesAsync(string, IEnumerable{string}, CancellationToken)"/>
    public static Task AppendAllLinesAsync(this AbsolutePath path, IEnumerable<string> contents,
        CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.AppendAllLinesAsync(path, contents, cancellationToken);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.AppendAllLinesAsync(string, IEnumerable{string}, Encoding, CancellationToken)"/>
    public static Task AppendAllLinesAsync(this AbsolutePath path, IEnumerable<string> contents, Encoding encoding,
        CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.AppendAllLinesAsync(path, contents, encoding, cancellationToken);
    }
#endif


    /// <inheritdoc cref = "File.AppendAllText(string, string? )"/>
    public static void AppendAllText(this AbsolutePath path, string? contents, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.AppendAllText(path, contents);
    }

    /// <inheritdoc cref = "File.AppendAllText(string, string? , Encoding)"/>
    public static void AppendAllText(this AbsolutePath path, string? contents, Encoding encoding,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.AppendAllText(path, contents, encoding);
    }

#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.AppendAllText(string, ReadOnlySpan{char})"/>
    public static void AppendAllText(this AbsolutePath path, ReadOnlySpan<char> contents, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.AppendAllText(path, contents);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.AppendAllText(string, ReadOnlySpan{char}, Encoding)"/>
    public static void AppendAllText(this AbsolutePath path, ReadOnlySpan<char> contents, Encoding encoding,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.AppendAllText(path, contents, encoding);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.AppendAllTextAsync(string, string? , CancellationToken)"/>
    public static Task AppendAllTextAsync(this AbsolutePath path, string? contents, CancellationToken cancellationToken,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.AppendAllTextAsync(path, contents, cancellationToken);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.AppendAllTextAsync(string, string? , Encoding, CancellationToken)"/>
    public static Task AppendAllTextAsync(this AbsolutePath path, string? contents, Encoding encoding,
        CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.AppendAllTextAsync(path, contents, encoding, cancellationToken);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.AppendAllTextAsync(string, ReadOnlyMemory{char}, CancellationToken)"/>
    public static Task AppendAllTextAsync(this AbsolutePath path, ReadOnlyMemory<char> contents,
        CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.AppendAllTextAsync(path, contents, cancellationToken);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.AppendAllTextAsync(string, ReadOnlyMemory{char}, Encoding, CancellationToken)"/>
    public static Task AppendAllTextAsync(this AbsolutePath path, ReadOnlyMemory<char> contents, Encoding encoding,
        CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.AppendAllTextAsync(path, contents, encoding, cancellationToken);
    }
#endif


    /// <inheritdoc cref = "File.AppendText(string)"/>
    public static StreamWriter AppendText(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.AppendText(path);
    }

    /// <inheritdoc cref = "File.Create(string)"/>
    public static FileSystemStream FileCreate(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.Create(path);
    }

    /// <inheritdoc cref = "File.Create(string, int)"/>
    public static FileSystemStream FileCreate(this AbsolutePath path, int bufferSize, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.Create(path, bufferSize);
    }

    /// <inheritdoc cref = "File.Create(string, int, FileOptions)"/>
    public static FileSystemStream FileCreate(this AbsolutePath path, int bufferSize, FileOptions options,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.Create(path, bufferSize, options);
    }

#if FEATURE_FILESYSTEM_LINK
    /// <inheritdoc cref = "File.CreateSymbolicLink(string, string)"/>
    public static IFileSystemInfo FileCreateSymbolicLink(this AbsolutePath path, AbsolutePath pathToTarget,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.CreateSymbolicLink(path, pathToTarget);
    }
#endif

    /// <inheritdoc cref="File.Replace(string, string, string)" />
    public static void FileReplace(this AbsolutePath sourceFileName, AbsolutePath destinationFileName,
        AbsolutePath? destinationBackupFileName, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.Replace(sourceFileName, destinationFileName, destinationBackupFileName);
    }

    /// <inheritdoc cref="File.Replace(string, string, string, bool)" />
    public static void FileReplace(this AbsolutePath sourceFileName, AbsolutePath destinationFileName,
        AbsolutePath? destinationBackupFileName, bool ignoreMetadataErrors, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.Replace(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors);
    }

    /// <inheritdoc cref = "File.CreateText(string)"/>
    public static StreamWriter CreateText(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.CreateText(path);
    }

    /// <inheritdoc cref = "File.Decrypt(string)"/>
    /// <inheritdoc cref = "File.Decrypt(string)"/>
    [SupportedOSPlatform("windows")]
    public static void Decrypt(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.Decrypt(path);
    }

    /// <inheritdoc cref = "File.Delete(string)"/>
    public static void FileDelete(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.Delete(path);
    }

    /// <inheritdoc cref = "File.Encrypt(string)"/>
    /// <inheritdoc cref = "File.Encrypt(string)"/>
    [SupportedOSPlatform("windows")]
    public static void Encrypt(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.Encrypt(path);
    }

    /// <inheritdoc cref = "File.Exists(string? )"/>
    public static bool FileExists([NotNullWhen(true)] this AbsolutePath? path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.Exists(path);
    }
    
    /// <inheritdoc cref = "File.Exists(string? )"/>
    public static bool FileExists(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.Exists(path);
    }

    /// <inheritdoc cref = "File.GetAttributes(string)"/>
    public static FileAttributes FileGetAttributes(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.GetAttributes(path);
    }

    /// <inheritdoc cref = "File.GetCreationTime(string)"/>
    public static DateTime FileGetCreationTime(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.GetCreationTime(path);
    }

    /// <inheritdoc cref = "File.GetCreationTimeUtc(string)"/>
    public static DateTime FileGetCreationTimeUtc(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.GetCreationTimeUtc(path);
    }

    /// <inheritdoc cref = "File.GetLastAccessTime(string)"/>
    public static DateTime FileGetLastAccessTime(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.GetLastAccessTime(path);
    }

    /// <inheritdoc cref = "File.GetLastAccessTimeUtc(string)"/>
    public static DateTime FileGetLastAccessTimeUtc(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.GetLastAccessTimeUtc(path);
    }

    /// <inheritdoc cref = "File.GetLastWriteTime(string)"/>
    public static DateTime FileGetLastWriteTime(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.GetLastWriteTime(path);
    }

    /// <inheritdoc cref = "File.GetLastWriteTimeUtc(string)"/>
    public static DateTime FileGetLastWriteTimeUtc(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.GetLastWriteTimeUtc(path);
    }

#if FEATURE_FILESYSTEM_UNIXFILEMODE
    /// <inheritdoc cref = "File.GetUnixFileMode(string)"/>
    [UnsupportedOSPlatform("windows")]
    public static UnixFileMode FileGetUnixFileMode(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.GetUnixFileMode(path);
    }
#endif


    /// <inheritdoc cref = "File.Open(string, FileMode)"/>
    public static FileSystemStream Open(this AbsolutePath path, FileMode mode, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.Open(path, mode);
    }

    /// <inheritdoc cref = "File.Open(string, FileMode, FileAccess)"/>
    public static FileSystemStream Open(this AbsolutePath path, FileMode mode, FileAccess access,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.Open(path, mode, access);
    }

    /// <inheritdoc cref = "File.Open(string, FileMode, FileAccess, FileShare)"/>
    public static FileSystemStream Open(this AbsolutePath path, FileMode mode, FileAccess access, FileShare share,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.Open(path, mode, access, share);
    }

#if FEATURE_FILESYSTEM_STREAM_OPTIONS
    /// <inheritdoc cref = "File.Open(string, FileStreamOptions)"/>
    public static FileSystemStream Open(this AbsolutePath path, FileStreamOptions options,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.Open(path, options);
    }
#endif


    /// <inheritdoc cref = "File.OpenRead(string)"/>
    public static FileSystemStream OpenRead(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.OpenRead(path);
    }

    /// <inheritdoc cref = "File.OpenText(string)"/>
    public static StreamReader OpenText(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.OpenText(path);
    }

    /// <inheritdoc cref = "File.OpenWrite(string)"/>
    public static FileSystemStream OpenWrite(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.OpenWrite(path);
    }

    /// <inheritdoc cref = "File.ReadAllBytes(string)"/>
    public static byte[] ReadAllBytes(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadAllBytes(path);
    }

#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.ReadAllBytesAsync(string, CancellationToken)"/>
    public static Task<byte[]> ReadAllBytesAsync(this AbsolutePath path, CancellationToken cancellationToken,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadAllBytesAsync(path, cancellationToken);
    }
#endif


    /// <inheritdoc cref = "File.ReadAllLines(string)"/>
    public static string[] ReadAllLines(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadAllLines(path);
    }

    /// <inheritdoc cref = "File.ReadAllLines(string, Encoding)"/>
    public static string[] ReadAllLines(this AbsolutePath path, Encoding encoding, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadAllLines(path, encoding);
    }

#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.ReadAllLinesAsync(string, CancellationToken)"/>
    public static Task<string[]> ReadAllLinesAsync(this AbsolutePath path, CancellationToken cancellationToken,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadAllLinesAsync(path, cancellationToken);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.ReadAllLinesAsync(string, Encoding, CancellationToken)"/>
    public static Task<string[]> ReadAllLinesAsync(this AbsolutePath path, Encoding encoding,
        CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadAllLinesAsync(path, encoding, cancellationToken);
    }
#endif


    /// <inheritdoc cref = "File.ReadAllText(string)"/>
    public static string ReadAllText(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadAllText(path);
    }

    /// <inheritdoc cref = "File.ReadAllText(string, Encoding)"/>
    public static string ReadAllText(this AbsolutePath path, Encoding encoding, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadAllText(path, encoding);
    }

#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.ReadAllTextAsync(string, CancellationToken)"/>
    public static Task<string> ReadAllTextAsync(this AbsolutePath path, CancellationToken cancellationToken,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadAllTextAsync(path, cancellationToken);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.ReadAllTextAsync(string, Encoding, CancellationToken)"/>
    public static Task<string> ReadAllTextAsync(this AbsolutePath path, Encoding encoding,
        CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadAllTextAsync(path, encoding, cancellationToken);
    }
#endif


    /// <inheritdoc cref = "File.ReadLines(string)"/>
    public static IEnumerable<string> ReadLines(this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadLines(path);
    }

    /// <inheritdoc cref = "File.ReadLines(string, Encoding)"/>
    public static IEnumerable<string> ReadLines(this AbsolutePath path, Encoding encoding,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadLines(path, encoding);
    }

#if FEATURE_FILESYSTEM_NET_7_OR_GREATER
    /// <inheritdoc cref = "File.ReadLinesAsync(string, CancellationToken)"/>
    public static IAsyncEnumerable<string> ReadLinesAsync(this AbsolutePath path,
        CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadLinesAsync(path, cancellationToken);
        
    }
#endif


#if FEATURE_FILESYSTEM_NET_7_OR_GREATER
    /// <inheritdoc cref = "File.ReadLinesAsync(string, Encoding, CancellationToken)"/>
    public static IAsyncEnumerable<string> ReadLinesAsync(this AbsolutePath path, Encoding encoding,
       CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadLinesAsync(path, encoding, cancellationToken);
    }
#endif

    /// <inheritdoc cref = "File.WriteAllBytes(string, byte[])"/>
    public static void WriteAllBytes(this AbsolutePath path, byte[] bytes, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.WriteAllBytes(path, bytes);
    }

#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.WriteAllBytes(string, ReadOnlySpan{byte})"/>
    public static void WriteAllBytes(this AbsolutePath path, ReadOnlySpan<byte> bytes, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.WriteAllBytes(path, bytes);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.WriteAllBytesAsync(string, byte[], CancellationToken)"/>
    public static Task WriteAllBytesAsync(this AbsolutePath path, byte[] bytes, CancellationToken cancellationToken,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.WriteAllBytesAsync(path, bytes, cancellationToken);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.WriteAllBytesAsync(string, ReadOnlyMemory{byte}, CancellationToken)"/>
    public static Task WriteAllBytesAsync(this AbsolutePath path, ReadOnlyMemory<byte> bytes,
        CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.WriteAllBytesAsync(path, bytes, cancellationToken);
    }
#endif


    /// <inheritdoc cref = "File.WriteAllLines(string, string[])"/>
    public static void WriteAllLines(this AbsolutePath path, string[] contents, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.WriteAllLines(path, contents);
    }

    /// <inheritdoc cref = "File.WriteAllLines(string, IEnumerable{string})"/>
    public static void WriteAllLines(this AbsolutePath path, IEnumerable<string> contents,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.WriteAllLines(path, contents);
    }

    /// <inheritdoc cref = "File.WriteAllLines(string, string[], Encoding)"/>
    public static void WriteAllLines(this AbsolutePath path, string[] contents, Encoding encoding,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.WriteAllLines(path, contents, encoding);
    }

    /// <inheritdoc cref = "File.WriteAllLines(string, IEnumerable{string}, Encoding)"/>
    public static void WriteAllLines(this AbsolutePath path, IEnumerable<string> contents, Encoding encoding,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.WriteAllLines(path, contents, encoding);
    }

#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.WriteAllLinesAsync(string, IEnumerable{string}, CancellationToken)"/>
    public static Task WriteAllLinesAsync(this AbsolutePath path, IEnumerable<string> contents,
        CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.WriteAllLinesAsync(path, contents, cancellationToken);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.WriteAllLinesAsync(string, IEnumerable{string}, Encoding, CancellationToken)"/>
    public static Task WriteAllLinesAsync(this AbsolutePath path, IEnumerable<string> contents, Encoding encoding,
        CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.WriteAllLinesAsync(path, contents, encoding, cancellationToken);
    }
#endif


    /// <inheritdoc cref = "File.WriteAllText(string, string? )"/>
    public static void WriteAllText(this AbsolutePath path, string? contents, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.WriteAllText(path, contents);
    }

    /// <inheritdoc cref = "File.WriteAllText(string, string? , Encoding)"/>
    public static void WriteAllText(this AbsolutePath path, string? contents, Encoding encoding,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.WriteAllText(path, contents, encoding);
    }

#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.WriteAllText(string, ReadOnlySpan{char})"/>
    public static void WriteAllText(this AbsolutePath path, ReadOnlySpan<char> contents, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.WriteAllText(path, contents);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.WriteAllText(string, ReadOnlySpan{char}, Encoding)"/>
    public static void WriteAllText(this AbsolutePath path, ReadOnlySpan<char> contents, Encoding encoding,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.WriteAllText(path, contents, encoding);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.WriteAllTextAsync(string, string? , CancellationToken)"/>
    public static Task WriteAllTextAsync(this AbsolutePath path, string? contents, CancellationToken cancellationToken,
        IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.WriteAllTextAsync(path, contents, cancellationToken);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.WriteAllTextAsync(string, string? , Encoding, CancellationToken)"/>
    public static Task WriteAllTextAsync(this AbsolutePath path, string? contents, Encoding encoding,
        CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.WriteAllTextAsync(path, contents, encoding, cancellationToken);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.WriteAllTextAsync(string, ReadOnlyMemory{char}, CancellationToken)"/>
    public static Task WriteAllTextAsync(this AbsolutePath path, ReadOnlyMemory<char> contents,
        CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.WriteAllTextAsync(path, contents, cancellationToken);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.WriteAllTextAsync(string, ReadOnlyMemory{char}, Encoding, CancellationToken)"/>
    public static Task WriteAllTextAsync(this AbsolutePath path, ReadOnlyMemory<char> contents, Encoding encoding,
        CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.WriteAllTextAsync(path, contents, encoding, cancellationToken);
    }
#endif
    
    /// <inheritdoc cref = "File.SetAttributes(string, FileAttributes)"/>
public static void FileSetAttributes(this AbsolutePath path, FileAttributes fileAttributes, IFileSystem? fileSystem = null)
{
    fileSystem ??= new FileSystem();
    fileSystem.File.SetAttributes(path, fileAttributes);
}

/// <inheritdoc cref = "File.SetCreationTime(string, DateTime)"/>
public static void FileSetCreationTime(this AbsolutePath path, DateTime creationTime, IFileSystem? fileSystem = null)
{
    fileSystem ??= new FileSystem();
    fileSystem.File.SetCreationTime(path, creationTime);
}

/// <inheritdoc cref = "File.SetCreationTimeUtc(string, DateTime)"/>
public static void FileSetCreationTimeUtc(this AbsolutePath path, DateTime creationTimeUtc, IFileSystem? fileSystem = null)
{
    fileSystem ??= new FileSystem();
    fileSystem.File.SetCreationTimeUtc(path, creationTimeUtc);
}

/// <inheritdoc cref = "File.SetLastAccessTime(string, DateTime)"/>
public static void FileSetLastAccessTime(this AbsolutePath path, DateTime lastAccessTime, IFileSystem? fileSystem = null)
{
    fileSystem ??= new FileSystem();
    fileSystem.File.SetLastAccessTime(path, lastAccessTime);
}

/// <inheritdoc cref = "File.SetLastAccessTimeUtc(string, DateTime)"/>
public static void FileSetLastAccessTimeUtc(this AbsolutePath path, DateTime lastAccessTimeUtc, IFileSystem? fileSystem = null)
{
    fileSystem ??= new FileSystem();
    fileSystem.File.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
}

/// <inheritdoc cref = "File.SetLastWriteTime(string, DateTime)"/>
public static void FileSetLastWriteTime(this AbsolutePath path, DateTime lastWriteTime, IFileSystem? fileSystem = null)
{
    fileSystem ??= new FileSystem();
    fileSystem.File.SetLastWriteTime(path, lastWriteTime);
}

/// <inheritdoc cref = "File.SetLastWriteTimeUtc(string, DateTime)"/>
public static void FileSetLastWriteTimeUtc(this AbsolutePath path, DateTime lastWriteTimeUtc, IFileSystem? fileSystem = null)
{
    fileSystem ??= new FileSystem();
    fileSystem.File.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
}

#if FEATURE_FILESYSTEM_UNIXFILEMODE
/// <inheritdoc cref = "File.SetUnixFileMode(string, UnixFileMode)"/>
[UnsupportedOSPlatform("windows")]
public static void FileSetUnixFileMode(this AbsolutePath path, UnixFileMode mode, IFileSystem? fileSystem = null)
{
    fileSystem ??= new FileSystem();
    fileSystem.File.SetUnixFileMode(path, mode);
}
#endif

    ///<inheritdoc cref="File.Copy(string,string)"/>
    public static void FileCopy(this AbsolutePath sourceFileName, AbsolutePath destFileName, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.Copy(sourceFileName.Value, destFileName.Value);
    }
    
    ///<inheritdoc cref="File.Copy(string,string,bool)"/>
    public static void FileCopy(this AbsolutePath sourceFileName, AbsolutePath destFileName, bool overwrite, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.Copy(sourceFileName.Value, destFileName.Value, overwrite: overwrite);
    }
    
    
    
    /// <inheritdoc cref="File.Move(string, string)" />
    public static void FileMove(this AbsolutePath sourceFileName, AbsolutePath destFileName, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.Move(sourceFileName.Value, destFileName.Value);
    }
    
#if FEATURE_FILE_MOVETO_OVERWRITE
    /// <inheritdoc cref="File.Move(string, string, bool)" />
    public static void FileMove(this AbsolutePath sourceFileName, AbsolutePath destFileName, bool overwrite, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.Move(sourceFileName.Value, destFileName.Value, overwrite: overwrite);
    }
#endif
    



}