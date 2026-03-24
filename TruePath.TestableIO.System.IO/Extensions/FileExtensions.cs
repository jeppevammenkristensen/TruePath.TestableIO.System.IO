using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using System.Text;
using TruePath;
// ReSharper disable CheckNamespace

namespace System.IO.Abstractions;

/// <summary>
/// Provides a collection of extension methods for performing common file operations on an instance of <see cref="IFile"/>.
/// </summary>
public static partial class FileExtensions
{
#if FEATURE_FILE_SPAN
    /// <inheritdoc cref="File.AppendAllBytes(string,byte[])" />
    public static void AppendAllBytes(this IFile file, AbsolutePath path, byte[] bytes)
    {
        file.AppendAllBytes(path.Value, bytes);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref="File.AppendAllBytes(string,ReadOnlySpan{byte})" />
    public static void AppendAllBytes(this IFile file, AbsolutePath path, ReadOnlySpan<byte> bytes)
    {
        file.AppendAllBytes(path.Value, bytes);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref="File.AppendAllBytesAsync(string,byte[],CancellationToken)" />
    public static async Task AppendAllBytesAsync(this IFile file, AbsolutePath path, byte[] bytes,
        CancellationToken cancellationToken)
    {
        await file.AppendAllBytesAsync(path.Value, bytes, cancellationToken);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref="File.AppendAllBytesAsync(string,ReadOnlyMemory{byte},CancellationToken)" />
    public static async Task AppendAllBytesAsync(this IFile file, AbsolutePath path, ReadOnlyMemory<byte> bytes,
        CancellationToken cancellationToken)
    {
        await file.AppendAllBytesAsync(path.Value, bytes, cancellationToken);
    }
#endif


    /// <inheritdoc cref="File.AppendAllLines(string, IEnumerable{string})" />
    public static void AppendAllLines(this IFile file, AbsolutePath path, IEnumerable<string> contents)
    {
        file.AppendAllLines(path.Value, contents);
    }


    /// <inheritdoc cref="File.AppendAllLines(string, IEnumerable{string}, Encoding)" />
    public static void AppendAllLines(this IFile file, AbsolutePath path, IEnumerable<string> contents,
        Encoding encoding)
    {
        file.AppendAllLines(path.Value, contents, encoding);
    }


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref="File.AppendAllLinesAsync(string, IEnumerable{string}, CancellationToken)" />
    public static async Task AppendAllLinesAsync(this IFile file, AbsolutePath path, IEnumerable<string> contents,
        CancellationToken cancellationToken)
    {
        await file.AppendAllLinesAsync(path.Value, contents, cancellationToken);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref="File.AppendAllLinesAsync(string, IEnumerable{string}, Encoding, CancellationToken)" />
    public static async Task AppendAllLinesAsync(this IFile file, AbsolutePath path, IEnumerable<string> contents,
        Encoding encoding, CancellationToken cancellationToken)
    {
        await file.AppendAllLinesAsync(path.Value, contents, encoding, cancellationToken);
    }
#endif


    /// <inheritdoc cref="File.AppendAllText(string, string?)" />
    public static void AppendAllText(this IFile file, AbsolutePath path, string? contents)
    {
        file.AppendAllText(path.Value, contents);
    }


    /// <inheritdoc cref="File.AppendAllText(string, string?, Encoding)" />
    public static void AppendAllText(this IFile file, AbsolutePath path, string? contents, Encoding encoding)
    {
        file.AppendAllText(path.Value, contents, encoding);
    }


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref="File.AppendAllText(string,ReadOnlySpan{char})" />
    public static void AppendAllText(this IFile file, AbsolutePath path, ReadOnlySpan<char> contents)
    {
        file.AppendAllText(path.Value, contents);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref="File.AppendAllText(string,ReadOnlySpan{char},Encoding)" />
    public static void AppendAllText(this IFile file, AbsolutePath path, ReadOnlySpan<char> contents, Encoding encoding)
    {
        file.AppendAllText(path.Value, contents, encoding);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref="File.AppendAllTextAsync(string, string?, CancellationToken)" />
    public static async Task AppendAllTextAsync(this IFile file, AbsolutePath path, string? contents,
        CancellationToken cancellationToken)
    {
        await file.AppendAllTextAsync(path.Value, contents, cancellationToken);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref="File.AppendAllTextAsync(string, string?, Encoding, CancellationToken)" />
    public static async Task AppendAllTextAsync(this IFile file, AbsolutePath path, string? contents, Encoding encoding,
        CancellationToken cancellationToken)
    {
        await file.AppendAllTextAsync(path.Value, contents, encoding, cancellationToken);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref="File.AppendAllTextAsync(string,ReadOnlyMemory{char},CancellationToken)" />
    public static async Task AppendAllTextAsync(this IFile file, AbsolutePath path, ReadOnlyMemory<char> contents,
        CancellationToken cancellationToken)
    {
        await file.AppendAllTextAsync(path.Value, contents, cancellationToken);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref="File.AppendAllTextAsync(string,ReadOnlyMemory{char},Encoding,CancellationToken)" />
    public static async Task AppendAllTextAsync(this IFile file, AbsolutePath path, ReadOnlyMemory<char> contents,
        Encoding encoding, CancellationToken cancellationToken)
    {
        await file.AppendAllTextAsync(path.Value, contents, encoding, cancellationToken);
    }
#endif


    /// <inheritdoc cref="File.AppendText(string)" />
    public static StreamWriter AppendText(this IFile file, AbsolutePath path)
    {
        var result = file.AppendText(path.Value);
        return result;
    }


    /// <inheritdoc cref="File.Create(string)" />
    public static FileSystemStream Create(this IFile file, AbsolutePath path)
    {
        var result = file.Create(path.Value);
        return result;
    }


    /// <inheritdoc cref="File.Create(string, int)" />
    public static FileSystemStream Create(this IFile file, AbsolutePath path, int bufferSize)
    {
        var result = file.Create(path.Value, bufferSize);
        return result;
    }


    /// <inheritdoc cref="File.Create(string, int, FileOptions)" />
    public static FileSystemStream Create(this IFile file, AbsolutePath path, int bufferSize, FileOptions options)
    {
        var result = file.Create(path.Value, bufferSize, options);
        return result;
    }


#if FEATURE_FILESYSTEM_LINK
    /// <inheritdoc cref="File.CreateSymbolicLink(string, string)" />
    public static IFileSystemInfo CreateSymbolicLink(this IFile file, AbsolutePath path, AbsolutePath pathToTarget)
    {
        var result = file.CreateSymbolicLink(path.Value, pathToTarget.Value);
        return result;
    }
#endif


    /// <inheritdoc cref="File.CreateText(string)" />
    public static StreamWriter CreateText(this IFile file, AbsolutePath path)
    {
        var result = file.CreateText(path.Value);
        return result;
    }


    /// <inheritdoc cref="File.Decrypt(string)" />
    /// <inheritdoc cref="File.Decrypt(string)" />
    [SupportedOSPlatform("windows")]
    public static void Decrypt(this IFile file, AbsolutePath path)
    {
        file.Decrypt(path.Value);
    }


    /// <inheritdoc cref="File.Delete(string)" />
    public static void Delete(this IFile file, AbsolutePath path)
    {
        file.Delete(path.Value);
    }


    /// <inheritdoc cref="File.Encrypt(string)" />
    /// <inheritdoc cref="File.Encrypt(string)" />
    [SupportedOSPlatform("windows")]
    public static void Encrypt(this IFile file, AbsolutePath path)
    {
        file.Encrypt(path.Value);
    }


    /// <inheritdoc cref="File.Exists(string?)" />
    public static bool Exists(this IFile file, [NotNullWhen(true)] AbsolutePath? path)
    {
        var result = file.Exists(path?.Value);
        return result;
    }


    /// <inheritdoc cref="File.GetAttributes(string)" />
    public static FileAttributes GetAttributes(this IFile file, AbsolutePath path)
    {
        var result = file.GetAttributes(path.Value);
        return result;
    }


    /// <inheritdoc cref="File.GetCreationTime(string)" />
    public static DateTime GetCreationTime(this IFile file, AbsolutePath path)
    {
        var result = file.GetCreationTime(path.Value);
        return result;
    }


    /// <inheritdoc cref="File.GetCreationTimeUtc(string)" />
    public static DateTime GetCreationTimeUtc(this IFile file, AbsolutePath path)
    {
        var result = file.GetCreationTimeUtc(path.Value);
        return result;
    }


    /// <inheritdoc cref="File.GetLastAccessTime(string)" />
    public static DateTime GetLastAccessTime(this IFile file, AbsolutePath path)
    {
        var result = file.GetLastAccessTime(path.Value);
        return result;
    }


    /// <inheritdoc cref="File.GetLastAccessTimeUtc(string)" />
    public static DateTime GetLastAccessTimeUtc(this IFile file, AbsolutePath path)
    {
        var result = file.GetLastAccessTimeUtc(path.Value);
        return result;
    }


    /// <inheritdoc cref="File.GetLastWriteTime(string)" />
    public static DateTime GetLastWriteTime(this IFile file, AbsolutePath path)
    {
        var result = file.GetLastWriteTime(path.Value);
        return result;
    }


    /// <inheritdoc cref="File.GetLastWriteTimeUtc(string)" />
    public static DateTime GetLastWriteTimeUtc(this IFile file, AbsolutePath path)
    {
        var result = file.GetLastWriteTimeUtc(path.Value);
        return result;
    }


#if FEATURE_FILESYSTEM_UNIXFILEMODE
    /// <inheritdoc cref="File.GetUnixFileMode(string)" />
    [UnsupportedOSPlatform("windows")]
    public static UnixFileMode GetUnixFileMode(this IFile file, AbsolutePath path)
    {
        var result = file.GetUnixFileMode(path.Value);
        return result;
    }
#endif


    /// <inheritdoc cref="File.Open(string, FileMode)" />
    public static FileSystemStream Open(this IFile file, AbsolutePath path, FileMode mode)
    {
        var result = file.Open(path.Value, mode);
        return result;
    }


    /// <inheritdoc cref="File.Open(string, FileMode, FileAccess)" />
    public static FileSystemStream Open(this IFile file, AbsolutePath path, FileMode mode, FileAccess access)
    {
        var result = file.Open(path.Value, mode, access);
        return result;
    }


    /// <inheritdoc cref="File.Open(string, FileMode, FileAccess, FileShare)" />
    public static FileSystemStream Open(this IFile file, AbsolutePath path, FileMode mode, FileAccess access,
        FileShare share)
    {
        var result = file.Open(path.Value, mode, access, share);
        return result;
    }


#if FEATURE_FILESYSTEM_STREAM_OPTIONS
    /// <inheritdoc cref="File.Open(string, FileStreamOptions)" />
    public static FileSystemStream Open(this IFile file, AbsolutePath path, FileStreamOptions options)
    {
        var result = file.Open(path.Value, options);
        return result;
    }
#endif


    /// <inheritdoc cref="File.OpenRead(string)" />
    public static FileSystemStream OpenRead(this IFile file, AbsolutePath path)
    {
        var result = file.OpenRead(path.Value);
        return result;
    }


    /// <inheritdoc cref="File.OpenText(string)" />
    public static StreamReader OpenText(this IFile file, AbsolutePath path)
    {
        var result = file.OpenText(path.Value);
        return result;
    }


    /// <inheritdoc cref="File.OpenWrite(string)" />
    public static FileSystemStream OpenWrite(this IFile file, AbsolutePath path)
    {
        var result = file.OpenWrite(path.Value);
        return result;
    }


    /// <inheritdoc cref="File.ReadAllBytes(string)" />
    public static byte[] ReadAllBytes(this IFile file, AbsolutePath path)
    {
        var result = file.ReadAllBytes(path.Value);
        return result;
    }


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref="File.ReadAllBytesAsync(string, CancellationToken)" />
    public static async Task<byte[]> ReadAllBytesAsync(this IFile file, AbsolutePath path,
        CancellationToken cancellationToken)
    {
        var result = await file.ReadAllBytesAsync(path.Value, cancellationToken);
        return result;
    }
#endif


    /// <inheritdoc cref="File.ReadAllLines(string)" />
    public static string[] ReadAllLines(this IFile file, AbsolutePath path)
    {
        return file.ReadAllLines(path.Value);
    }


    /// <inheritdoc cref="File.ReadAllLines(string, Encoding)" />
    public static string[] ReadAllLines(this IFile file, AbsolutePath path, Encoding encoding)
    {
        return  file.ReadAllLines(path.Value, encoding);
    }


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref="File.ReadAllLinesAsync(string, CancellationToken)" />
    public static async Task<string[]> ReadAllLinesAsync(this IFile file, AbsolutePath path,
        CancellationToken cancellationToken)
    {
        return await file.ReadAllLinesAsync(path.Value, cancellationToken);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref="File.ReadAllLinesAsync(string, Encoding, CancellationToken)" />
    public static async Task<string[]> ReadAllLinesAsync(this IFile file, AbsolutePath path, Encoding encoding,
        CancellationToken cancellationToken)
    {
        return await file.ReadAllLinesAsync(path.Value, encoding, cancellationToken);
    }
#endif


    /// <inheritdoc cref="File.ReadAllText(string)" />
    public static string ReadAllText(this IFile file, AbsolutePath path)
    {
        return  file.ReadAllText(path.Value);
    }


    /// <inheritdoc cref="File.ReadAllText(string, Encoding)" />
    public static string ReadAllText(this IFile file, AbsolutePath path, Encoding encoding)
    {
        return file.ReadAllText(path.Value, encoding);
    }


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref="File.ReadAllTextAsync(string, CancellationToken)" />
    public static async Task<string> ReadAllTextAsync(this IFile file, AbsolutePath path,
        CancellationToken cancellationToken)
    {
        var result = await file.ReadAllTextAsync(path.Value, cancellationToken);
        return result;
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref="File.ReadAllTextAsync(string, Encoding, CancellationToken)" />
    public static async Task<string> ReadAllTextAsync(this IFile file, AbsolutePath path, Encoding encoding,
        CancellationToken cancellationToken)
    {
        return await file.ReadAllTextAsync(path.Value, encoding, cancellationToken);
    }
#endif


    /// <inheritdoc cref="File.ReadLines(string)" />
    public static IEnumerable<string> ReadLines(this IFile file, AbsolutePath path)
    {
        return file.ReadLines(path.Value);
    }


    /// <inheritdoc cref="File.ReadLines(string, Encoding)" />
    public static IEnumerable<string> ReadLines(this IFile file, AbsolutePath path, Encoding encoding)
    {
        return file.ReadLines(path.Value, encoding);
    }


#if FEATURE_FILESYSTEM_NET_7_OR_GREATER
    /// <inheritdoc cref="File.ReadLinesAsync(string, CancellationToken)" />
    public static IAsyncEnumerable<string> ReadLinesAsync(this IFile file, AbsolutePath path,
         CancellationToken cancellationToken)
    {
        return file.ReadLinesAsync(path.Value, cancellationToken);
    }
#endif


#if FEATURE_FILESYSTEM_NET_7_OR_GREATER
    /// <inheritdoc cref="File.ReadLinesAsync(string, Encoding, CancellationToken)" />
    public static IAsyncEnumerable<string> ReadLinesAsync(this IFile file, AbsolutePath path,
        Encoding encoding,CancellationToken cancellationToken)
    {
        return file.ReadLinesAsync(path.Value, encoding, cancellationToken);
        
    }
#endif


    /// <inheritdoc cref="File.SetAttributes(string, FileAttributes)" />
    public static void SetAttributes(this IFile file, AbsolutePath path, FileAttributes fileAttributes)
    {
        file.SetAttributes(path.Value, fileAttributes);
    }


    /// <inheritdoc cref="File.SetCreationTime(string, DateTime)" />
    public static void SetCreationTime(this IFile file, AbsolutePath path, DateTime creationTime)
    {
        file.SetCreationTime(path.Value, creationTime);
    }


    /// <inheritdoc cref="File.SetCreationTimeUtc(string, DateTime)" />
    public static void SetCreationTimeUtc(this IFile file, AbsolutePath path, DateTime creationTimeUtc)
    {
        file.SetCreationTimeUtc(path.Value, creationTimeUtc);
    }


    /// <inheritdoc cref="File.SetLastAccessTime(string, DateTime)" />
    public static void SetLastAccessTime(this IFile file, AbsolutePath path, DateTime lastAccessTime)
    {
        file.SetLastAccessTime(path.Value, lastAccessTime);
    }


    /// <inheritdoc cref="File.SetLastAccessTimeUtc(string, DateTime)" />
    public static void SetLastAccessTimeUtc(this IFile file, AbsolutePath path, DateTime lastAccessTimeUtc)
    {
        file.SetLastAccessTimeUtc(path.Value, lastAccessTimeUtc);
    }


    /// <inheritdoc cref="File.SetLastWriteTime(string, DateTime)" />
    public static void SetLastWriteTime(this IFile file, AbsolutePath path, DateTime lastWriteTime)
    {
        file.SetLastWriteTime(path.Value, lastWriteTime);
    }


    /// <inheritdoc cref="File.SetLastWriteTimeUtc(string, DateTime)" />
    public static void SetLastWriteTimeUtc(this IFile file, AbsolutePath path, DateTime lastWriteTimeUtc)
    {
        file.SetLastWriteTimeUtc(path.Value, lastWriteTimeUtc);
    }


#if FEATURE_FILESYSTEM_UNIXFILEMODE
    /// <inheritdoc cref="File.SetUnixFileMode(string, UnixFileMode)" />
    [UnsupportedOSPlatform("windows")]
    public static void SetUnixFileMode(this IFile file, AbsolutePath path, UnixFileMode mode)
    {
        file.SetUnixFileMode(path.Value, mode);
    }
#endif


    /// <inheritdoc cref="File.WriteAllBytes(string, byte[])" />
    public static void WriteAllBytes(this IFile file, AbsolutePath path, byte[] bytes)
    {
        file.WriteAllBytes(path.Value, bytes);
    }


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref="File.WriteAllBytes(string,ReadOnlySpan{byte})" />
    public static void WriteAllBytes(this IFile file, AbsolutePath path, ReadOnlySpan<byte> bytes)
    {
        file.WriteAllBytes(path.Value, bytes);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref="File.WriteAllBytesAsync(string, byte[], CancellationToken)" />
    public static async Task WriteAllBytesAsync(this IFile file, AbsolutePath path, byte[] bytes,
        CancellationToken cancellationToken)
    {
        await file.WriteAllBytesAsync(path.Value, bytes, cancellationToken);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref="File.WriteAllBytesAsync(string,ReadOnlyMemory{byte},CancellationToken)" />
    public static async Task WriteAllBytesAsync(this IFile file, AbsolutePath path, ReadOnlyMemory<byte> bytes,
        CancellationToken cancellationToken)
    {
        await file.WriteAllBytesAsync(path.Value, bytes, cancellationToken);
    }
#endif


    /// <inheritdoc cref="File.WriteAllLines(string, string[])" />
    public static void WriteAllLines(this IFile file, AbsolutePath path, string[] contents)
    {
        file.WriteAllLines(path.Value, contents);
    }


    /// <inheritdoc cref="File.WriteAllLines(string, IEnumerable{string})" />
    public static void WriteAllLines(this IFile file, AbsolutePath path, IEnumerable<string> contents)
    {
        file.WriteAllLines(path.Value, contents);
    }


    /// <inheritdoc cref="File.WriteAllLines(string, string[], Encoding)" />
    public static void WriteAllLines(this IFile file, AbsolutePath path, string[] contents, Encoding encoding)
    {
        file.WriteAllLines(path.Value, contents, encoding);
    }


    /// <inheritdoc cref="File.WriteAllLines(string, IEnumerable{string}, Encoding)" />
    public static void WriteAllLines(this IFile file, AbsolutePath path, IEnumerable<string> contents,
        Encoding encoding)
    {
        file.WriteAllLines(path.Value, contents, encoding);
    }


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref="File.WriteAllLinesAsync(string, IEnumerable{string}, CancellationToken)" />
    public static async Task WriteAllLinesAsync(this IFile file, AbsolutePath path, IEnumerable<string> contents,
        CancellationToken cancellationToken)
    {
        await file.WriteAllLinesAsync(path.Value, contents, cancellationToken);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref="File.WriteAllLinesAsync(string, IEnumerable{string}, Encoding, CancellationToken)" />
    public static async Task WriteAllLinesAsync(this IFile file, AbsolutePath path, IEnumerable<string> contents,
        Encoding encoding, CancellationToken cancellationToken)
    {
        await file.WriteAllLinesAsync(path.Value, contents, encoding, cancellationToken);
    }
#endif


    /// <inheritdoc cref="File.WriteAllText(string, string?)" />
    public static void WriteAllText(this IFile file, AbsolutePath path, string? contents)
    {
        file.WriteAllText(path.Value, contents);
    }


    /// <inheritdoc cref="File.WriteAllText(string, string?, Encoding)" />
    public static void WriteAllText(this IFile file, AbsolutePath path, string? contents, Encoding encoding)
    {
        file.WriteAllText(path.Value, contents, encoding);
    }


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref="File.WriteAllText(string,ReadOnlySpan{char})" />
    public static void WriteAllText(this IFile file, AbsolutePath path, ReadOnlySpan<char> contents)
    {
        file.WriteAllText(path.Value, contents);
    }
#endif


#if FEATURE_FILE_SPAN

    /// <inheritdoc cref="File.WriteAllText(string,ReadOnlySpan{char},Encoding)" />
    public static void WriteAllText(this IFile file, AbsolutePath path, ReadOnlySpan<char> contents, Encoding encoding)
    {
        file.WriteAllText(path.Value, contents, encoding);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref="File.WriteAllTextAsync(string, string?, CancellationToken)" />
    public static async Task WriteAllTextAsync(this IFile file, AbsolutePath path, string? contents,
        CancellationToken cancellationToken)
    {
        await file.WriteAllTextAsync(path.Value, contents, cancellationToken);
    }
#endif


#if FEATURE_FILESYSTEM_ASYNC
    /// <inheritdoc cref="File.WriteAllTextAsync(string, string?, Encoding, CancellationToken)" />
    public static async Task WriteAllTextAsync(this IFile file, AbsolutePath path, string? contents, Encoding encoding,
        CancellationToken cancellationToken)
    {
        await file.WriteAllTextAsync(path.Value, contents, encoding, cancellationToken);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref="File.WriteAllTextAsync(string,ReadOnlyMemory{char},CancellationToken)" />
    public static async Task WriteAllTextAsync(this IFile file, AbsolutePath path, ReadOnlyMemory<char> contents,
        CancellationToken cancellationToken)
    {
        await file.WriteAllTextAsync(path.Value, contents, cancellationToken);
    }
#endif


#if FEATURE_FILE_SPAN
    /// <inheritdoc cref="File.WriteAllTextAsync(string,ReadOnlyMemory{char},Encoding,CancellationToken)" />
    public static async Task WriteAllTextAsync(this IFile file, AbsolutePath path, ReadOnlyMemory<char> contents,
        Encoding encoding, CancellationToken cancellationToken)
    {
        await file.WriteAllTextAsync(path.Value, contents, encoding, cancellationToken);
    }
#endif
}