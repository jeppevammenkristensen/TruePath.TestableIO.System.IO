using System.Diagnostics.CodeAnalysis;
using System.IO.Abstractions;
using System.Runtime.Versioning;
using System.Text;

namespace TruePath.TestableIO.System.IO;

/// <summary>
/// Direct static methods for <see cref="IFile"/> related operationss
/// </summary>
public static class FileIO 
{
#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "FileExtensions.AppendAllBytes(AbsolutePath, byte[], IFileSystem? )"/>
    public static void AppendAllBytes(AbsolutePath path, byte[] bytes, IFileSystem? fileSystem = null)
    {
        path.AppendAllBytes(bytes, fileSystem);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "FileExtensions.AppendAllBytes(AbsolutePath, ReadOnlySpan{byte},IFileSystem?)"/>
    public static void AppendAllBytes(AbsolutePath path, ReadOnlySpan<byte> bytes, IFileSystem? fileSystem = null)
    {
        path.AppendAllBytes(bytes, fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.AppendAllBytesAsync(AbsolutePath, byte[], CancellationToken, IFileSystem? )"/>
    public static Task AppendAllBytesAsync(AbsolutePath path, byte[] bytes, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.AppendAllBytesAsync(bytes, cancellationToken, fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.AppendAllBytesAsync(AbsolutePath, ReadOnlyMemory{byte},CancellationToken,IFileSystem?)"/>
    public static Task AppendAllBytesAsync(AbsolutePath path, ReadOnlyMemory<byte> bytes, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.AppendAllBytesAsync(bytes, cancellationToken, fileSystem);
    }

#endif


    /// <inheritdoc cref = "FileExtensions.AppendAllLines(AbsolutePath, IEnumerable{string}, IFileSystem? )"/>
    public static void AppendAllLines(AbsolutePath path, IEnumerable<string> contents, IFileSystem? fileSystem = null)
    {
        path.AppendAllLines(contents, fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.AppendAllLines(AbsolutePath, IEnumerable{string}, Encoding, IFileSystem? )"/>
    public static void AppendAllLines(AbsolutePath path, IEnumerable<string> contents, Encoding encoding, IFileSystem? fileSystem = null)
    {
        path.AppendAllLines(contents, encoding, fileSystem);
    }


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "FileExtensions.AppendAllLinesAsync(AbsolutePath, IEnumerable{string}, CancellationToken, IFileSystem? )"/>
    public static Task AppendAllLinesAsync(AbsolutePath path, IEnumerable<string> contents, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.AppendAllLinesAsync(contents, cancellationToken, fileSystem);
    }
#endif
    
#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "FileExtensions.AppendAllLinesAsync(AbsolutePath, IEnumerable{string}, Encoding, CancellationToken, IFileSystem? )"/>
    public static Task AppendAllLinesAsync(AbsolutePath path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.AppendAllLinesAsync(contents, encoding, cancellationToken, fileSystem);
    }

#endif


    /// <inheritdoc cref = "FileExtensions.AppendAllText(AbsolutePath, string? , IFileSystem? )"/>
    public static void AppendAllText(AbsolutePath path, string? contents, IFileSystem? fileSystem = null)
    {
        path.AppendAllText(contents, fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.AppendAllText(AbsolutePath, string? , Encoding, IFileSystem? )"/>
    public static void AppendAllText(AbsolutePath path, string? contents, Encoding encoding, IFileSystem? fileSystem = null)
    {
        path.AppendAllText(contents, encoding, fileSystem);
    }


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "FileExtensions.AppendAllText(AbsolutePath, ReadOnlySpan{char}, IFileSystem? )"/>
    public static void AppendAllText(AbsolutePath path, ReadOnlySpan<char> contents, IFileSystem? fileSystem = null)
    {
        path.AppendAllText(contents, fileSystem);
    }

#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "FileExtensions.AppendAllText(AbsolutePath, ReadOnlySpan{char}, Encoding, IFileSystem? )"/>
    public static void AppendAllText(AbsolutePath path, ReadOnlySpan<char> contents, Encoding encoding, IFileSystem? fileSystem = null)
    {
        path.AppendAllText(contents, encoding, fileSystem);
    }

#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "FileExtensions.AppendAllTextAsync(AbsolutePath, string? , CancellationToken, IFileSystem? )"/>
    public static Task AppendAllTextAsync(AbsolutePath path, string? contents, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.AppendAllTextAsync(contents, cancellationToken, fileSystem);
    }

#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "FileExtensions.AppendAllTextAsync(AbsolutePath, string? , Encoding, CancellationToken, IFileSystem? )"/>
    public static Task AppendAllTextAsync(AbsolutePath path, string? contents, Encoding encoding, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.AppendAllTextAsync(contents, encoding, cancellationToken, fileSystem);
    }

#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "FileExtensions.AppendAllTextAsync(AbsolutePath, ReadOnlyMemory{char}, CancellationToken, IFileSystem? )"/>
    public static Task AppendAllTextAsync(AbsolutePath path, ReadOnlyMemory<char> contents, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.AppendAllTextAsync(contents, cancellationToken, fileSystem);
    }

#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "FileExtensions.AppendAllTextAsync(AbsolutePath, ReadOnlyMemory{char}, Encoding, CancellationToken, IFileSystem? )"/>
    public static Task AppendAllTextAsync(AbsolutePath path, ReadOnlyMemory<char> contents, Encoding encoding, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.AppendAllTextAsync(contents, encoding, cancellationToken, fileSystem);
    }

#endif


    /// <inheritdoc cref = "FileExtensions.AppendText(AbsolutePath, IFileSystem? )"/>
    public static StreamWriter AppendText(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.AppendText(fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.FileCreate(AbsolutePath, IFileSystem? )"/>
    public static FileSystemStream Create(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.FileCreate(fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.FileCreate(AbsolutePath, int, IFileSystem? )"/>
    public static FileSystemStream Create(AbsolutePath path, int bufferSize, IFileSystem? fileSystem = null)
    {
        return path.FileCreate(bufferSize, fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.FileCreate(AbsolutePath, int, FileOptions, IFileSystem? )"/>
    public static FileSystemStream Create(AbsolutePath path, int bufferSize, FileOptions options, IFileSystem? fileSystem = null)
    {
        return path.FileCreate(bufferSize, options, fileSystem);
    }


#if FEATURE_FILESYSTEM_LINK
    /// <inheritdoc cref = "FileExtensions.FileCreateSymbolicLink(AbsolutePath, AbsolutePath, IFileSystem? )"/>
    public static IFileSystemInfo CreateSymbolicLink(AbsolutePath path, AbsolutePath pathToTarget, IFileSystem? fileSystem = null)
    {
        return path.FileCreateSymbolicLink(pathToTarget, fileSystem);
    }

#endif

    /// <inheritdoc cref = "FileExtensions.CreateText(AbsolutePath, IFileSystem? )"/>
    public static StreamWriter CreateText(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.CreateText(fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.Decrypt(AbsolutePath, IFileSystem? )"/>
    [SupportedOSPlatform("windows")]
    public static void Decrypt(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        path.Decrypt(fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.FileDelete(AbsolutePath, IFileSystem? )"/>
    public static void Delete(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        path.FileDelete(fileSystem);
    }


    /// <inheritdoc cref = "FileExtensions.Encrypt(AbsolutePath, IFileSystem? )"/>
    [SupportedOSPlatform("windows")]
    public static void Encrypt(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        path.Encrypt(fileSystem);
    }

/// <inheritdoc cref = "FileExtensions.FileExists(AbsolutePath? , IFileSystem? )"/>
public static bool Exists([NotNullWhen(true)] AbsolutePath? path, IFileSystem? fileSystem = null)
{
    return path.FileExists(fileSystem);
}
/// <inheritdoc cref = "FileExtensions.FileExists(AbsolutePath, IFileSystem? )"/>
public static bool Exists(AbsolutePath path, IFileSystem? fileSystem = null)
{
    return path.FileExists(fileSystem);
}
/// <inheritdoc cref = "FileExtensions.FileGetAttributes(AbsolutePath, IFileSystem? )"/>
public static FileAttributes GetAttributes(AbsolutePath path, IFileSystem? fileSystem = null)
{
    return path.FileGetAttributes(fileSystem);
}
/// <inheritdoc cref = "FileExtensions.FileGetCreationTime(AbsolutePath, IFileSystem? )"/>
public static DateTime GetCreationTime(AbsolutePath path, IFileSystem? fileSystem = null)
{
    return path.FileGetCreationTime(fileSystem);
}
/// <inheritdoc cref = "FileExtensions.FileGetCreationTimeUtc(AbsolutePath, IFileSystem? )"/>
public static DateTime GetCreationTimeUtc(AbsolutePath path, IFileSystem? fileSystem = null)
{
    return path.FileGetCreationTimeUtc(fileSystem);
}
/// <inheritdoc cref = "FileExtensions.FileGetLastAccessTime(AbsolutePath, IFileSystem? )"/>
public static DateTime GetLastAccessTime(AbsolutePath path, IFileSystem? fileSystem = null)
{
    return path.FileGetLastAccessTime(fileSystem);
}
/// <inheritdoc cref = "FileExtensions.FileGetLastAccessTimeUtc(AbsolutePath, IFileSystem? )"/>
public static DateTime GetLastAccessTimeUtc(AbsolutePath path, IFileSystem? fileSystem = null)
{
    return path.FileGetLastAccessTimeUtc(fileSystem);
}
/// <inheritdoc cref = "FileExtensions.FileGetLastWriteTime(AbsolutePath, IFileSystem? )"/>
public static DateTime GetLastWriteTime(AbsolutePath path, IFileSystem? fileSystem = null)
{
    return path.FileGetLastWriteTime(fileSystem);
}
/// <inheritdoc cref = "FileExtensions.FileGetLastWriteTimeUtc(AbsolutePath, IFileSystem? )"/>
public static DateTime GetLastWriteTimeUtc(AbsolutePath path, IFileSystem? fileSystem = null)
{
    return path.FileGetLastWriteTimeUtc(fileSystem);
}


#if FEATURE_FILESYSTEM_UNIXFILEMODE
    /// <inheritdoc cref = "FileExtensions.FileGetUnixFileMode(AbsolutePath, IFileSystem? )"/>
    [UnsupportedOSPlatform("windows")]
    public static UnixFileMode GetUnixFileMode(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.FileGetUnixFileMode(fileSystem);
    }

#endif

    /// <inheritdoc cref = "FileExtensions.Open(AbsolutePath, FileMode, IFileSystem? )"/>
    public static FileSystemStream Open(AbsolutePath path, FileMode mode, IFileSystem? fileSystem = null)
    {
        return path.Open(mode, fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.Open(AbsolutePath, FileMode, FileAccess, IFileSystem? )"/>
    public static FileSystemStream Open(AbsolutePath path, FileMode mode, FileAccess access, IFileSystem? fileSystem = null)
    {
        return path.Open(mode, access, fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.Open(AbsolutePath, FileMode, FileAccess, FileShare, IFileSystem? )"/>
    public static FileSystemStream Open(AbsolutePath path, FileMode mode, FileAccess access, FileShare share, IFileSystem? fileSystem = null)
    {
        return path.Open(mode, access, share, fileSystem);
    }


#if FEATURE_FILESYSTEM_STREAM_OPTIONS
    /// <inheritdoc cref = "FileExtensions.Open(AbsolutePath, FileStreamOptions, IFileSystem? )"/>
    public static FileSystemStream Open(AbsolutePath path, FileStreamOptions options, IFileSystem? fileSystem = null)
    {
        return path.Open(options, fileSystem);
    }

#endif

    /// <inheritdoc cref = "FileExtensions.OpenRead(AbsolutePath, IFileSystem? )"/>
    public static FileSystemStream OpenRead(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.OpenRead(fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.OpenText(AbsolutePath, IFileSystem? )"/>
    public static StreamReader OpenText(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.OpenText(fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.OpenWrite(AbsolutePath, IFileSystem? )"/>
    public static FileSystemStream OpenWrite(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.OpenWrite(fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.ReadAllBytes(AbsolutePath, IFileSystem? )"/>
    public static byte[] ReadAllBytes(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.ReadAllBytes(fileSystem);
    }


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "FileExtensions.ReadAllBytesAsync(AbsolutePath, CancellationToken, IFileSystem? )"/>
    public static Task<byte[]> ReadAllBytesAsync(AbsolutePath path, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.ReadAllBytesAsync(cancellationToken, fileSystem);
    }

#endif

    /// <inheritdoc cref = "FileExtensions.ReadAllLines(AbsolutePath, IFileSystem? )"/>
    public static string[] ReadAllLines(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.ReadAllLines(fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.ReadAllLines(AbsolutePath, Encoding, IFileSystem? )"/>
    public static string[] ReadAllLines(AbsolutePath path, Encoding encoding, IFileSystem? fileSystem = null)
    {
        return path.ReadAllLines(encoding, fileSystem);
    }


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "FileExtensions.ReadAllLinesAsync(AbsolutePath, CancellationToken, IFileSystem? )"/>
    public static Task<string[]> ReadAllLinesAsync(AbsolutePath path, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.ReadAllLinesAsync(cancellationToken, fileSystem);
    }

#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "FileExtensions.ReadAllLinesAsync(AbsolutePath, Encoding, CancellationToken, IFileSystem? )"/>
    public static Task<string[]> ReadAllLinesAsync(AbsolutePath path, Encoding encoding, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.ReadAllLinesAsync(encoding, cancellationToken, fileSystem);
    }

#endif


    /// <inheritdoc cref = "FileExtensions.ReadAllText(AbsolutePath, IFileSystem? )"/>
    public static string ReadAllText(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.ReadAllText(fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.ReadAllText(AbsolutePath, Encoding, IFileSystem? )"/>
    public static string ReadAllText(AbsolutePath path, Encoding encoding, IFileSystem? fileSystem = null)
    {
        return path.ReadAllText(encoding, fileSystem);
    }


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "FileExtensions.ReadAllTextAsync(AbsolutePath, CancellationToken, IFileSystem? )"/>
    public static Task<string> ReadAllTextAsync(AbsolutePath path, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.ReadAllTextAsync(cancellationToken, fileSystem);
    }

#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "FileExtensions.ReadAllTextAsync(AbsolutePath, Encoding, CancellationToken, IFileSystem? )"/>
    public static Task<string> ReadAllTextAsync(AbsolutePath path, Encoding encoding, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.ReadAllTextAsync(encoding, cancellationToken, fileSystem);
    }

#endif


    /// <inheritdoc cref = "FileExtensions.ReadLines(AbsolutePath, IFileSystem? )"/>
    public static IEnumerable<string> ReadLines(AbsolutePath path, IFileSystem? fileSystem = null)
    {
        return path.ReadLines(fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.ReadLines(AbsolutePath, Encoding, IFileSystem? )"/>
    public static IEnumerable<string> ReadLines(AbsolutePath path, Encoding encoding, IFileSystem? fileSystem = null)
    {
        return path.ReadLines(encoding, fileSystem);
    }


#if FEATURE_FILESYSTEM_NET_7_OR_GREATER
    /// <inheritdoc cref = "FileExtensions.ReadLinesAsync(AbsolutePath, CancellationToken, IFileSystem? )"/>
    public static IAsyncEnumerable<string> ReadLinesAsync(AbsolutePath path, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.ReadLinesAsync(cancellationToken, fileSystem);
    }

#endif


#if FEATURE_FILESYSTEM_NET_7_OR_GREATER
    /// <inheritdoc cref = "FileExtensions.ReadLinesAsync(AbsolutePath, Encoding, CancellationToken, IFileSystem? )"/>
    public static IAsyncEnumerable<string> ReadLinesAsync(AbsolutePath path, Encoding encoding, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.ReadLinesAsync(encoding, cancellationToken, fileSystem);
    }

#endif

    /// <inheritdoc cref = "FileExtensions.WriteAllBytes(AbsolutePath, byte[], IFileSystem? )"/>
    public static void WriteAllBytes(AbsolutePath path, byte[] bytes, IFileSystem? fileSystem = null)
    {
        path.WriteAllBytes(bytes, fileSystem);
    }


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "FileExtensions.WriteAllBytes(AbsolutePath, ReadOnlySpan{byte}, IFileSystem? )"/>
    public static void WriteAllBytes(AbsolutePath path, ReadOnlySpan<byte> bytes, IFileSystem? fileSystem = null)
    {
        path.WriteAllBytes(bytes, fileSystem);
    }

#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "FileExtensions.WriteAllBytesAsync(AbsolutePath, byte[], CancellationToken, IFileSystem? )"/>
    public static Task WriteAllBytesAsync(AbsolutePath path, byte[] bytes, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.WriteAllBytesAsync(bytes, cancellationToken, fileSystem);
    }

#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "FileExtensions.WriteAllBytesAsync(AbsolutePath, ReadOnlyMemory{byte}, CancellationToken, IFileSystem? )"/>
    public static Task WriteAllBytesAsync(AbsolutePath path, ReadOnlyMemory<byte> bytes, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.WriteAllBytesAsync(bytes, cancellationToken, fileSystem);
    }

#endif

    /// <inheritdoc cref = "FileExtensions.WriteAllLines(AbsolutePath, string[], IFileSystem? )"/>
    public static void WriteAllLines(AbsolutePath path, string[] contents, IFileSystem? fileSystem = null)
    {
        path.WriteAllLines(contents, fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.WriteAllLines(AbsolutePath, IEnumerable{string}, IFileSystem? )"/>
    public static void WriteAllLines(AbsolutePath path, IEnumerable<string> contents, IFileSystem? fileSystem = null)
    {
        path.WriteAllLines(contents, fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.WriteAllLines(AbsolutePath, string[], Encoding, IFileSystem? )"/>
    public static void WriteAllLines(AbsolutePath path, string[] contents, Encoding encoding, IFileSystem? fileSystem = null)
    {
        path.WriteAllLines(contents, encoding, fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.WriteAllLines(AbsolutePath, IEnumerable{string}, Encoding, IFileSystem? )"/>
    public static void WriteAllLines(AbsolutePath path, IEnumerable<string> contents, Encoding encoding, IFileSystem? fileSystem = null)
    {
        path.WriteAllLines(contents, encoding, fileSystem);
    }


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "FileExtensions.WriteAllLinesAsync(AbsolutePath, IEnumerable{string}, CancellationToken, IFileSystem? )"/>
    public static Task WriteAllLinesAsync(AbsolutePath path, IEnumerable<string> contents, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.WriteAllLinesAsync(contents, cancellationToken, fileSystem);
    }

#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "FileExtensions.WriteAllLinesAsync(AbsolutePath, IEnumerable{string}, Encoding, CancellationToken, IFileSystem? )"/>
    public static Task WriteAllLinesAsync(AbsolutePath path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.WriteAllLinesAsync(contents, encoding, cancellationToken, fileSystem);
    }

#endif

    /// <inheritdoc cref = "FileExtensions.WriteAllText(AbsolutePath, string? , IFileSystem? )"/>
    public static void WriteAllText(AbsolutePath path, string? contents, IFileSystem? fileSystem = null)
    {
        path.WriteAllText(contents, fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.WriteAllText(AbsolutePath, string? , Encoding, IFileSystem? )"/>
    public static void WriteAllText(AbsolutePath path, string? contents, Encoding encoding, IFileSystem? fileSystem = null)
    {
        path.WriteAllText(contents, encoding, fileSystem);
    }


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "FileExtensions.WriteAllText(AbsolutePath, ReadOnlySpan{char}, IFileSystem? )"/>
    public static void WriteAllText(AbsolutePath path, ReadOnlySpan<char> contents, IFileSystem? fileSystem = null)
    {
        path.WriteAllText(contents, fileSystem);
    }

#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "FileExtensions.WriteAllText(AbsolutePath, ReadOnlySpan{char}, Encoding, IFileSystem? )"/>
    public static void WriteAllText(AbsolutePath path, ReadOnlySpan<char> contents, Encoding encoding, IFileSystem? fileSystem = null)
    {
        path.WriteAllText(contents, encoding, fileSystem);
    }

#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "FileExtensions.WriteAllTextAsync(AbsolutePath, string? , CancellationToken, IFileSystem? )"/>
    public static Task WriteAllTextAsync(AbsolutePath path, string? contents, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.WriteAllTextAsync(contents, cancellationToken, fileSystem);
    }

#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "FileExtensions.WriteAllTextAsync(AbsolutePath, string? , Encoding, CancellationToken, IFileSystem? )"/>
    public static Task WriteAllTextAsync(AbsolutePath path, string? contents, Encoding encoding, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.WriteAllTextAsync(contents, encoding, cancellationToken, fileSystem);
    }

#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "FileExtensions.WriteAllTextAsync(AbsolutePath, ReadOnlyMemory{char}, CancellationToken, IFileSystem? )"/>
    public static Task WriteAllTextAsync(AbsolutePath path, ReadOnlyMemory<char> contents, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.WriteAllTextAsync(contents, cancellationToken, fileSystem);
    }

#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "FileExtensions.WriteAllTextAsync(AbsolutePath, ReadOnlyMemory{char}, Encoding, CancellationToken, IFileSystem? )"/>
    public static Task WriteAllTextAsync(AbsolutePath path, ReadOnlyMemory<char> contents, Encoding encoding, CancellationToken cancellationToken, IFileSystem? fileSystem = null)
    {
        return path.WriteAllTextAsync(contents, encoding, cancellationToken, fileSystem);
    }

#endif
    
    /// <inheritdoc cref = "FileExtensions.FileSetAttributes(AbsolutePath, FileAttributes, IFileSystem? )"/>
    public static void SetAttributes(AbsolutePath path, FileAttributes fileAttributes, IFileSystem? fileSystem = null)
    {
        path.FileSetAttributes(fileAttributes, fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.FileSetCreationTime(AbsolutePath, DateTime, IFileSystem? )"/>
    public static void SetCreationTime(AbsolutePath path, DateTime creationTime, IFileSystem? fileSystem = null)
    {
        path.FileSetCreationTime(creationTime, fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.FileSetCreationTimeUtc(AbsolutePath, DateTime, IFileSystem? )"/>
    public static void SetCreationTimeUtc(AbsolutePath path, DateTime creationTimeUtc, IFileSystem? fileSystem = null)
    {
        path.FileSetCreationTimeUtc(creationTimeUtc, fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.FileSetLastAccessTime(AbsolutePath, DateTime, IFileSystem? )"/>
    public static void SetLastAccessTime(AbsolutePath path, DateTime lastAccessTime, IFileSystem? fileSystem = null)
    {
        path.FileSetLastAccessTime(lastAccessTime, fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.FileSetLastAccessTimeUtc(AbsolutePath, DateTime, IFileSystem? )"/>
    public static void SetLastAccessTimeUtc(AbsolutePath path, DateTime lastAccessTimeUtc, IFileSystem? fileSystem = null)
    {
        path.FileSetLastAccessTimeUtc(lastAccessTimeUtc, fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.FileSetLastWriteTime(AbsolutePath, DateTime, IFileSystem? )"/>
    public static void SetLastWriteTime(AbsolutePath path, DateTime lastWriteTime, IFileSystem? fileSystem = null)
    {
        path.FileSetLastWriteTime(lastWriteTime, fileSystem);
    }
    /// <inheritdoc cref = "FileExtensions.FileSetLastWriteTimeUtc(AbsolutePath, DateTime, IFileSystem? )"/>
    public static void SetLastWriteTimeUtc(AbsolutePath path, DateTime lastWriteTimeUtc, IFileSystem? fileSystem = null)
    {
        path.FileSetLastWriteTimeUtc(lastWriteTimeUtc, fileSystem);
    }


#if FEATURE_FILESYSTEM_UNIXFILEMODE
    /// <inheritdoc cref = "FileExtensions.FileSetUnixFileMode(AbsolutePath, UnixFileMode, IFileSystem? )"/>
    [UnsupportedOSPlatform("windows")]
    public static void SetUnixFileMode(AbsolutePath path, UnixFileMode mode, IFileSystem? fileSystem = null)
    {
        path.FileSetUnixFileMode(mode, fileSystem);
    }
#endif

    /// <inheritdoc cref="File.Replace(string, string, string)" />
    public static void Replace(AbsolutePath sourceFileName, AbsolutePath destinationFileName,
        AbsolutePath? destinationBackupFileName, IFileSystem? fileSystem)
    {
        sourceFileName.FileReplace(destinationFileName, destinationBackupFileName, fileSystem);
    }
    
    /// <inheritdoc cref="File.Replace(string, string, string, bool)" />
    public static void Replace(AbsolutePath sourceFileName, AbsolutePath destinationFileName,
        AbsolutePath? destinationBackupFileName, bool ignoreMetadataErrors, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        sourceFileName.FileReplace(destinationFileName, destinationBackupFileName, ignoreMetadataErrors, fileSystem);
    }
    
    ///<inheritdoc cref="File.Copy(string,string)"/>
    public static void Copy(AbsolutePath sourceFileName, AbsolutePath destFileName, IFileSystem? fileSystem = null)
    {
        sourceFileName.FileCopy(destFileName, fileSystem);
    }
    
    ///<inheritdoc cref="File.Copy(string,string,bool)"/>
    public static void Copy(AbsolutePath sourceFileName, AbsolutePath destFileName, bool overwrite, IFileSystem? fileSystem = null)
    {
        sourceFileName.FileCopy(destFileName, overwrite: overwrite, fileSystem);
    }
    
    /// <inheritdoc cref="File.Move(string, string)" />
    public static void Move(AbsolutePath sourceFileName, AbsolutePath destFileName, IFileSystem? fileSystem = null)
    {
        sourceFileName.FileMove(destFileName, fileSystem);
    }
    
#if FEATURE_FILE_MOVETO_OVERWRITE
    /// <inheritdoc cref="File.Move(string, string, bool)" />
    public static void Move(AbsolutePath sourceFileName, AbsolutePath destFileName, bool overwrite, IFileSystem? fileSystem = null)
    {
        sourceFileName.FileMove(destFileName, overwrite: overwrite, fileSystem);
    }
#endif

}