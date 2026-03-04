using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Text;
using TruePath;

namespace System.IO.Abstractions;

public static partial class FileExtensions
{
#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.AppendAllBytes(string, byte[])"/>
    public static void AppendAllBytes(this AbsolutePath path, byte[] bytes, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.AppendAllBytes(path, bytes);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.AppendAllBytes(string, ReadOnlySpan{byte})"/>
    public static void AppendAllBytes(this AbsolutePath path, ReadOnlySpan<byte> bytes, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.AppendAllBytes(path, bytes);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.AppendAllBytesAsync(string, byte[], CancellationToken)"/>
    public static Task AppendAllBytesAsync(this AbsolutePath path, byte[] bytes, CancellationToken cancellationToken,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.AppendAllBytesAsync(path, bytes, cancellationToken);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.AppendAllBytesAsync(string, ReadOnlyMemory{byte}, CancellationToken)"/>
    public static Task AppendAllBytesAsync(this AbsolutePath path, ReadOnlyMemory<byte> bytes,
        CancellationToken cancellationToken, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.AppendAllBytesAsync(path, bytes, cancellationToken);
    }
#endif


    /// <inheritdoc cref = "File.AppendAllLines(string, IEnumerable{string})"/>
    public static void AppendAllLines(this AbsolutePath path, IEnumerable<string> contents,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.AppendAllLines(path, contents);
    }

    /// <inheritdoc cref = "File.AppendAllLines(string, IEnumerable{string}, Encoding)"/>
    public static void AppendAllLines(this AbsolutePath path, IEnumerable<string> contents, Encoding encoding,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.AppendAllLines(path, contents, encoding);
    }

#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.AppendAllLinesAsync(string, IEnumerable{string}, CancellationToken)"/>
    public static Task AppendAllLinesAsync(this AbsolutePath path, IEnumerable<string> contents,
        CancellationToken cancellationToken, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.AppendAllLinesAsync(path, contents, cancellationToken);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.AppendAllLinesAsync(string, IEnumerable{string}, Encoding, CancellationToken)"/>
    public static Task AppendAllLinesAsync(this AbsolutePath path, IEnumerable<string> contents, Encoding encoding,
        CancellationToken cancellationToken, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.AppendAllLinesAsync(path, contents, encoding, cancellationToken);
    }
#endif


    /// <inheritdoc cref = "File.AppendAllText(string, string? )"/>
    public static void AppendAllText(this AbsolutePath path, string? contents, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.AppendAllText(path, contents);
    }

    /// <inheritdoc cref = "File.AppendAllText(string, string? , Encoding)"/>
    public static void AppendAllText(this AbsolutePath path, string? contents, Encoding encoding,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.AppendAllText(path, contents, encoding);
    }

#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.AppendAllText(string, ReadOnlySpan{char})"/>
    public static void AppendAllText(this AbsolutePath path, ReadOnlySpan<char> contents, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.AppendAllText(path, contents);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.AppendAllText(string, ReadOnlySpan{char}, Encoding)"/>
    public static void AppendAllText(this AbsolutePath path, ReadOnlySpan<char> contents, Encoding encoding,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.AppendAllText(path, contents, encoding);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.AppendAllTextAsync(string, string? , CancellationToken)"/>
    public static Task AppendAllTextAsync(this AbsolutePath path, string? contents, CancellationToken cancellationToken,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.AppendAllTextAsync(path, contents, cancellationToken);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.AppendAllTextAsync(string, string? , Encoding, CancellationToken)"/>
    public static Task AppendAllTextAsync(this AbsolutePath path, string? contents, Encoding encoding,
        CancellationToken cancellationToken, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.AppendAllTextAsync(path, contents, encoding, cancellationToken);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.AppendAllTextAsync(string, ReadOnlyMemory{char}, CancellationToken)"/>
    public static Task AppendAllTextAsync(this AbsolutePath path, ReadOnlyMemory<char> contents,
        CancellationToken cancellationToken, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.AppendAllTextAsync(path, contents, cancellationToken);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.AppendAllTextAsync(string, ReadOnlyMemory{char}, Encoding, CancellationToken)"/>
    public static Task AppendAllTextAsync(this AbsolutePath path, ReadOnlyMemory<char> contents, Encoding encoding,
        CancellationToken cancellationToken, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.AppendAllTextAsync(path, contents, encoding, cancellationToken);
    }
#endif


    /// <inheritdoc cref = "File.AppendText(string)"/>
    public static StreamWriter AppendText(this AbsolutePath path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.AppendText(path);
    }

    /// <inheritdoc cref = "File.Create(string)"/>
    public static FileSystemStream Create(this AbsolutePath path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.Create(path);
    }

    /// <inheritdoc cref = "File.Create(string, int)"/>
    public static FileSystemStream Create(this AbsolutePath path, int bufferSize, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.Create(path, bufferSize);
    }

    /// <inheritdoc cref = "File.Create(string, int, FileOptions)"/>
    public static FileSystemStream Create(this AbsolutePath path, int bufferSize, FileOptions options,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.Create(path, bufferSize, options);
    }

#if FEATURE_FILESYSTEM_LINK
    /// <inheritdoc cref = "File.CreateSymbolicLink(string, string)"/>
    public static IFileSystemInfo CreateSymbolicLink(this AbsolutePath path, AbsolutePath pathToTarget,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.CreateSymbolicLink(path, pathToTarget);
    }
#endif


    /// <inheritdoc cref = "File.CreateText(string)"/>
    public static StreamWriter CreateText(this AbsolutePath path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.CreateText(path);
    }

    /// <inheritdoc cref = "File.Decrypt(string)"/>
    /// <inheritdoc cref = "File.Decrypt(string)"/>
    [SupportedOSPlatform("windows")]
    public static void Decrypt(this AbsolutePath path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.Decrypt(path);
    }

    /// <inheritdoc cref = "File.Delete(string)"/>
    public static void Delete(this AbsolutePath path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.Delete(path);
    }

    /// <inheritdoc cref = "File.Encrypt(string)"/>
    /// <inheritdoc cref = "File.Encrypt(string)"/>
    [SupportedOSPlatform("windows")]
    public static void Encrypt(this AbsolutePath path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.Encrypt(path);
    }

    /// <inheritdoc cref = "File.Exists(string? )"/>
    public static bool Exists([NotNullWhen(true)] this AbsolutePath? path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.Exists(path);
    }

    /// <inheritdoc cref = "File.GetAttributes(string)"/>
    public static FileAttributes GetAttributes(this AbsolutePath path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.GetAttributes(path);
    }

    /// <inheritdoc cref = "File.GetCreationTime(string)"/>
    public static DateTime GetCreationTime(this AbsolutePath path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.GetCreationTime(path);
    }

    /// <inheritdoc cref = "File.GetCreationTimeUtc(string)"/>
    public static DateTime GetCreationTimeUtc(this AbsolutePath path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.GetCreationTimeUtc(path);
    }

    /// <inheritdoc cref = "File.GetLastAccessTime(string)"/>
    public static DateTime GetLastAccessTime(this AbsolutePath path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.GetLastAccessTime(path);
    }

    /// <inheritdoc cref = "File.GetLastAccessTimeUtc(string)"/>
    public static DateTime GetLastAccessTimeUtc(this AbsolutePath path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.GetLastAccessTimeUtc(path);
    }

    /// <inheritdoc cref = "File.GetLastWriteTime(string)"/>
    public static DateTime GetLastWriteTime(this AbsolutePath path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.GetLastWriteTime(path);
    }

    /// <inheritdoc cref = "File.GetLastWriteTimeUtc(string)"/>
    public static DateTime GetLastWriteTimeUtc(this AbsolutePath path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.GetLastWriteTimeUtc(path);
    }

#if FEATURE_FILESYSTEM_UNIXFILEMODE
    /// <inheritdoc cref = "File.GetUnixFileMode(string)"/>
    [UnsupportedOSPlatform("windows")]
    public static UnixFileMode GetUnixFileMode(this AbsolutePath path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.GetUnixFileMode(path);
    }
#endif


    /// <inheritdoc cref = "File.Open(string, FileMode)"/>
    public static FileSystemStream Open(this AbsolutePath path, FileMode mode, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.Open(path, mode);
    }

    /// <inheritdoc cref = "File.Open(string, FileMode, FileAccess)"/>
    public static FileSystemStream Open(this AbsolutePath path, FileMode mode, FileAccess access,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.Open(path, mode, access);
    }

    /// <inheritdoc cref = "File.Open(string, FileMode, FileAccess, FileShare)"/>
    public static FileSystemStream Open(this AbsolutePath path, FileMode mode, FileAccess access, FileShare share,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.Open(path, mode, access, share);
    }

#if FEATURE_FILESYSTEM_STREAM_OPTIONS
    /// <inheritdoc cref = "File.Open(string, FileStreamOptions)"/>
    public static FileSystemStream Open(this AbsolutePath path, FileStreamOptions options,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.Open(path, options);
    }
#endif


    /// <inheritdoc cref = "File.OpenRead(string)"/>
    public static FileSystemStream OpenRead(this AbsolutePath path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.OpenRead(path);
    }

    /// <inheritdoc cref = "File.OpenText(string)"/>
    public static StreamReader OpenText(this AbsolutePath path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.OpenText(path);
    }

    /// <inheritdoc cref = "File.OpenWrite(string)"/>
    public static FileSystemStream OpenWrite(this AbsolutePath path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.OpenWrite(path);
    }

    /// <inheritdoc cref = "File.ReadAllBytes(string)"/>
    public static byte[] ReadAllBytes(this AbsolutePath path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadAllBytes(path);
    }

#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.ReadAllBytesAsync(string, CancellationToken)"/>
    public static Task<byte[]> ReadAllBytesAsync(this AbsolutePath path, CancellationToken cancellationToken,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadAllBytesAsync(path, cancellationToken);
    }
#endif


    /// <inheritdoc cref = "File.ReadAllLines(string)"/>
    public static AbsolutePath[] ReadAllLines(this AbsolutePath path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadAllLines(path);
    }

    /// <inheritdoc cref = "File.ReadAllLines(string, Encoding)"/>
    public static AbsolutePath[] ReadAllLines(this AbsolutePath path, Encoding encoding, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadAllLines(path, encoding);
    }

#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.ReadAllLinesAsync(string, CancellationToken)"/>
    public static Task<AbsolutePath[]> ReadAllLinesAsync(this AbsolutePath path, CancellationToken cancellationToken,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadAllLinesAsync(path, cancellationToken);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.ReadAllLinesAsync(string, Encoding, CancellationToken)"/>
    public static Task<AbsolutePath[]> ReadAllLinesAsync(this AbsolutePath path, Encoding encoding,
        CancellationToken cancellationToken, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadAllLinesAsync(path, encoding, cancellationToken);
    }
#endif


    /// <inheritdoc cref = "File.ReadAllText(string)"/>
    public static AbsolutePath ReadAllText(this AbsolutePath path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadAllText(path);
    }

    /// <inheritdoc cref = "File.ReadAllText(string, Encoding)"/>
    public static AbsolutePath ReadAllText(this AbsolutePath path, Encoding encoding, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadAllText(path, encoding);
    }

#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.ReadAllTextAsync(string, CancellationToken)"/>
    public static Task<AbsolutePath> ReadAllTextAsync(this AbsolutePath path, CancellationToken cancellationToken,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadAllTextAsync(path, cancellationToken);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.ReadAllTextAsync(string, Encoding, CancellationToken)"/>
    public static Task<AbsolutePath> ReadAllTextAsync(this AbsolutePath path, Encoding encoding,
        CancellationToken cancellationToken, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadAllTextAsync(path, encoding, cancellationToken);
    }
#endif


    /// <inheritdoc cref = "File.ReadLines(string)"/>
    public static IEnumerable<AbsolutePath> ReadLines(this AbsolutePath path, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadLines(path);
    }

    /// <inheritdoc cref = "File.ReadLines(string, Encoding)"/>
    public static IEnumerable<AbsolutePath> ReadLines(this AbsolutePath path, Encoding encoding,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadLines(path, encoding);
    }

#if FEATURE_FILESYSTEM_NET_7_OR_GREATER
    /// <inheritdoc cref = "File.ReadLinesAsync(string, CancellationToken)"/>
    public static async IAsyncEnumerable<AbsolutePath> ReadLinesAsync(this AbsolutePath path,
        [EnumeratorCancellation] CancellationToken cancellationToken, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        var result =  fileSystem.File.ReadLinesAsync(path, cancellationToken);
        await foreach (var absolutePath in result)
        {
            yield return absolutePath;
        }
    }
#endif


#if FEATURE_FILESYSTEM_NET_7_OR_GREATER
    /// <inheritdoc cref = "File.ReadLinesAsync(string, Encoding, CancellationToken)"/>
    public static IAsyncEnumerable<AbsolutePath> ReadLinesAsync(this AbsolutePath path, Encoding encoding,
       CancellationToken cancellationToken, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.ReadLinesAsync(path, encoding, cancellationToken);
    }
#endif

    /// <inheritdoc cref = "File.WriteAllBytes(string, byte[])"/>
    public static void WriteAllBytes(this AbsolutePath path, byte[] bytes, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.WriteAllBytes(path, bytes);
    }

#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.WriteAllBytes(string, ReadOnlySpan{byte})"/>
    public static void WriteAllBytes(this AbsolutePath path, ReadOnlySpan<byte> bytes, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.WriteAllBytes(path, bytes);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.WriteAllBytesAsync(string, byte[], CancellationToken)"/>
    public static Task WriteAllBytesAsync(this AbsolutePath path, byte[] bytes, CancellationToken cancellationToken,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.WriteAllBytesAsync(path, bytes, cancellationToken);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.WriteAllBytesAsync(string, ReadOnlyMemory{byte}, CancellationToken)"/>
    public static Task WriteAllBytesAsync(this AbsolutePath path, ReadOnlyMemory<byte> bytes,
        CancellationToken cancellationToken, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.WriteAllBytesAsync(path, bytes, cancellationToken);
    }
#endif


    /// <inheritdoc cref = "File.WriteAllLines(string, string[])"/>
    public static void WriteAllLines(this AbsolutePath path, string[] contents, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.WriteAllLines(path, contents);
    }

    /// <inheritdoc cref = "File.WriteAllLines(string, IEnumerable{string})"/>
    public static void WriteAllLines(this AbsolutePath path, IEnumerable<string> contents,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.WriteAllLines(path, contents);
    }

    /// <inheritdoc cref = "File.WriteAllLines(string, string[], Encoding)"/>
    public static void WriteAllLines(this AbsolutePath path, string[] contents, Encoding encoding,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.WriteAllLines(path, contents, encoding);
    }

    /// <inheritdoc cref = "File.WriteAllLines(string, IEnumerable{string}, Encoding)"/>
    public static void WriteAllLines(this AbsolutePath path, IEnumerable<string> contents, Encoding encoding,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.WriteAllLines(path, contents, encoding);
    }

#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.WriteAllLinesAsync(string, IEnumerable{string}, CancellationToken)"/>
    public static Task WriteAllLinesAsync(this AbsolutePath path, IEnumerable<string> contents,
        CancellationToken cancellationToken, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.WriteAllLinesAsync(path, contents, cancellationToken);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.WriteAllLinesAsync(string, IEnumerable{string}, Encoding, CancellationToken)"/>
    public static Task WriteAllLinesAsync(this AbsolutePath path, IEnumerable<string> contents, Encoding encoding,
        CancellationToken cancellationToken, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.WriteAllLinesAsync(path, contents, encoding, cancellationToken);
    }
#endif


    /// <inheritdoc cref = "File.WriteAllText(string, string? )"/>
    public static void WriteAllText(this AbsolutePath path, string? contents, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.WriteAllText(path, contents);
    }

    /// <inheritdoc cref = "File.WriteAllText(string, string? , Encoding)"/>
    public static void WriteAllText(this AbsolutePath path, string? contents, Encoding encoding,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.WriteAllText(path, contents, encoding);
    }

#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.WriteAllText(string, ReadOnlySpan{char})"/>
    public static void WriteAllText(this AbsolutePath path, ReadOnlySpan<char> contents, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.WriteAllText(path, contents);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.WriteAllText(string, ReadOnlySpan{char}, Encoding)"/>
    public static void WriteAllText(this AbsolutePath path, ReadOnlySpan<char> contents, Encoding encoding,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        fileSystem.File.WriteAllText(path, contents, encoding);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.WriteAllTextAsync(string, string? , CancellationToken)"/>
    public static Task WriteAllTextAsync(this AbsolutePath path, string? contents, CancellationToken cancellationToken,
        FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.WriteAllTextAsync(path, contents, cancellationToken);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref = "File.WriteAllTextAsync(string, string? , Encoding, CancellationToken)"/>
    public static Task WriteAllTextAsync(this AbsolutePath path, string? contents, Encoding encoding,
        CancellationToken cancellationToken, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.WriteAllTextAsync(path, contents, encoding, cancellationToken);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.WriteAllTextAsync(string, ReadOnlyMemory{char}, CancellationToken)"/>
    public static Task WriteAllTextAsync(this AbsolutePath path, ReadOnlyMemory<char> contents,
        CancellationToken cancellationToken, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.WriteAllTextAsync(path, contents, cancellationToken);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref = "File.WriteAllTextAsync(string, ReadOnlyMemory{char}, Encoding, CancellationToken)"/>
    public static Task WriteAllTextAsync(this AbsolutePath path, ReadOnlyMemory<char> contents, Encoding encoding,
        CancellationToken cancellationToken, FileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.File.WriteAllTextAsync(path, contents, encoding, cancellationToken);
    }
#endif
    
    /// <inheritdoc cref = "File.SetAttributes(string, FileAttributes)"/>
public static void FileSetAttributes(this AbsolutePath path, FileAttributes fileAttributes, FileSystem? fileSystem = null)
{
    fileSystem ??= new FileSystem();
    fileSystem.File.SetAttributes(path, fileAttributes);
}

/// <inheritdoc cref = "File.SetCreationTime(string, DateTime)"/>
public static void FileSetCreationTime(this AbsolutePath path, DateTime creationTime, FileSystem? fileSystem = null)
{
    fileSystem ??= new FileSystem();
    fileSystem.File.SetCreationTime(path, creationTime);
}

/// <inheritdoc cref = "File.SetCreationTimeUtc(string, DateTime)"/>
public static void FileSetCreationTimeUtc(this AbsolutePath path, DateTime creationTimeUtc, FileSystem? fileSystem = null)
{
    fileSystem ??= new FileSystem();
    fileSystem.File.SetCreationTimeUtc(path, creationTimeUtc);
}

/// <inheritdoc cref = "File.SetLastAccessTime(string, DateTime)"/>
public static void FileSetLastAccessTime(this AbsolutePath path, DateTime lastAccessTime, FileSystem? fileSystem = null)
{
    fileSystem ??= new FileSystem();
    fileSystem.File.SetLastAccessTime(path, lastAccessTime);
}

/// <inheritdoc cref = "File.SetLastAccessTimeUtc(string, DateTime)"/>
public static void FileSetLastAccessTimeUtc(this AbsolutePath path, DateTime lastAccessTimeUtc, FileSystem? fileSystem = null)
{
    fileSystem ??= new FileSystem();
    fileSystem.File.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
}

/// <inheritdoc cref = "File.SetLastWriteTime(string, DateTime)"/>
public static void FileSetLastWriteTime(this AbsolutePath path, DateTime lastWriteTime, FileSystem? fileSystem = null)
{
    fileSystem ??= new FileSystem();
    fileSystem.File.SetLastWriteTime(path, lastWriteTime);
}

/// <inheritdoc cref = "File.SetLastWriteTimeUtc(string, DateTime)"/>
public static void FileSetLastWriteTimeUtc(this AbsolutePath path, DateTime lastWriteTimeUtc, FileSystem? fileSystem = null)
{
    fileSystem ??= new FileSystem();
    fileSystem.File.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
}

#if FEATURE_FILESYSTEM_UNIXFILEMODE
/// <inheritdoc cref = "File.SetUnixFileMode(string, UnixFileMode)"/>
[UnsupportedOSPlatform("windows")]
public static void FileSetUnixFileMode(this AbsolutePath path, UnixFileMode mode, FileSystem? fileSystem = null)
{
    fileSystem ??= new FileSystem();
    fileSystem.File.SetUnixFileMode(path, mode);
}
#endif




}