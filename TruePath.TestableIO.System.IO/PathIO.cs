using System.Diagnostics.CodeAnalysis;
using System.IO.Abstractions;

namespace TruePath.TestableIO.System.IO;

using SystemIOPath = global::System.IO.Abstractions.IPath;

/// <summary>
/// 
/// </summary>
/// <remarks>The Join methods of Path have been removed as TruePath provides better ways to achieve this</remarks>
public static class PathIO
{
    /// <inheritdoc cref = "Path.ChangeExtension(string, string)"/>
    [return: NotNullIfNotNull("path")]
    public static AbsolutePath?
        ChangeExtension(AbsolutePath? path, string? extension, IFileSystem? fileSystem = null) =>
        SafePath(fileSystem).ChangeExtension(path, extension);
 
    /// <inheritdoc cref = "Path.ChangeExtension(string, string)"/>
    public static AbsolutePath? ChangeExtension(AbsolutePath path, string? extension, IFileSystem? fileSystem = null) => SafePath(fileSystem).ChangeExtension(path, extension);

    /// <inheritdoc cref = "Path.Combine(string, string)"/>
    public static AbsolutePath Combine(string path1, string path2,
        IFileSystem? fileSystem = null) => SafePath(fileSystem).CombineToPath(path1, path2);

    /// <inheritdoc cref = "Path.Combine(string, string, string)"/>
    public static AbsolutePath Combine(string path1, string path2, string path3 , IFileSystem? fileSystem = null) => SafePath(fileSystem).CombineToPath(path1, path2, path3);

    /// <inheritdoc cref = "Path.Combine(string, string, string, string)"/>
    public static AbsolutePath Combine(string path1, string path2, string path3, string path4,
        IFileSystem? fileSystem = null) => SafePath(fileSystem).CombineToPath(path1, path2, path3, path4);

    /// <inheritdoc cref = "Path.Combine(string[])"/>
    public static AbsolutePath Combine(string[] paths, IFileSystem? fileSystem = null) =>
        SafePath(fileSystem).CombineToPath(paths);

#if FEATURE_PATH_SPAN
    /// <inheritdoc cref="Path.Combine(ReadOnlySpan{string})" />
    public static AbsolutePath Combine(ReadOnlySpan<string> paths,
        IFileSystem? fileSystem = null) => SafePath(fileSystem).CombineToPath(paths);
#endif

#if FEATURE_PATH_ADVANCED
    /// <inheritdoc cref="Path.EndsInDirectorySeparator(string)" />
    public static bool EndsInDirectorySeparator(AbsolutePath path, IFileSystem? fileSystem = null) =>
        SafePath(fileSystem).EndsInDirectorySeparator(path);
#endif
#if FEATURE_FILESYSTEM_NET_7_OR_GREATER

    /// <inheritdoc cref="Path.Exists(string)" />
    public static bool Exists([NotNullWhen(true)] AbsolutePath path, IFileSystem? fileSystem = null) =>
        SafePath(fileSystem).Exists(path);
    
    
    /// <inheritdoc cref="Path.Exists(string)" />
    public static bool Exists ([NotNullWhen(true)] AbsolutePath? path, IFileSystem? fileSystem = null) => SafePath(fileSystem).Exists(path);
#endif

    // TODO: 
    // To be looked at later on as they have functionality allready covered by the TruePath library
    
    // /// <inheritdoc cref = "Path.GetDirectoryName(string)"/>
    // public static AbsolutePath? GetDirectoryName(this SystemIOPath source, AbsolutePath? path)
    // {
    //     var result = source.GetDirectoryName(path?.Value);
    //     return result.AsAbsolutePath();
    // }
    //
    //
    // /// <inheritdoc cref = "Path.GetExtension(string)"/>
    // [return: NotNullIfNotNull("path")]
    // public static AbsolutePath? GetExtension(this SystemIOPath source, AbsolutePath? path)
    // {
    //     var result = source.GetExtension(path?.Value);
    //     return result.AsAbsolutePath();
    // }
    //
    // /// <inheritdoc cref = "Path.GetFileName(string)"/>
    // [return: NotNullIfNotNull("path")]
    // public static AbsolutePath? GetFileName(this SystemIOPath source, AbsolutePath? path)
    // {
    //     var result = source.GetFileName(path?.Value);
    //     return result.AsAbsolutePath();
    // }
    //
    // /// <inheritdoc cref = "Path.GetFileNameWithoutExtension(string)"/>
    // [return: NotNullIfNotNull("path")]
    // public static AbsolutePath? GetFileNameWithoutExtension(this SystemIOPath source, AbsolutePath? path)
    // {
    //     var result = source.GetFileNameWithoutExtension(path?.Value);
    //     return result.AsAbsolutePath();
    // }

    /// <inheritdoc cref = "Path.GetFullPath(string)"/>
    public static AbsolutePath GetFullPath(string path, IFileSystem? fileSystem = null) =>
        SafePath(fileSystem).PathGetFullPath(path); 
  

#if FEATURE_PATH_RELATIVE
    /// <inheritdoc cref="Path.GetFullPath(string, string)" />
    public static AbsolutePath GetFullPath(string path, string basePath, IFileSystem? fileSystem = null) =>
        SafePath(fileSystem).PathGetFullPath(path, basePath);
#endif

    /// <inheritdoc cref = "Path.GetPathRoot(string? )"/>
    public static AbsolutePath? GetPathRoot(AbsolutePath? path, IFileSystem? fileSystem = null) =>
        SafePath(fileSystem).GetPathRoot(path);
   

#if FEATURE_PATH_RELATIVE
    /// <inheritdoc cref="Path.GetRelativePath(string, string)" />
    public static LocalPath GetRelativePath(string relativeTo, AbsolutePath path, IFileSystem? fileSystem = null) =>
        SafePath(fileSystem).GetRelativePath(relativeTo, path);
#endif

    /// <summary>
    /// This uses the approach defined in <see cref="Path.GetTempFileName()"/> to use
    /// GetTempPath and GetRandomFile 
    /// </summary>
    ///<inheritdoc cref = "Path.GetTempFileName()"/>
    public static AbsolutePath GetTempFileAbsolute(IFileSystem? fileSystem = null) => SafePath(fileSystem).GetTempFileAbsolute();

    /// <inheritdoc cref = "Path.GetTempPath()"/>
    public static AbsolutePath GetTempPathAbsolute(IFileSystem? fileSystem = null) =>
        SafePath(fileSystem).GetTempPathAbsolute();


    /// <inheritdoc cref = "Path.HasExtension(string)"/>
    public static bool HasExtension(AbsolutePath path, IFileSystem? fileSystem = null) => SafePath(fileSystem).HasExtension(path);

    /// <inheritdoc cref = "Path.HasExtension(string)"/>
    public static bool HasExtension([NotNullWhen(true)] AbsolutePath? path, IFileSystem? fileSystem = null) => SafePath(fileSystem).HasExtension(path);
    
    
#if FEATURE_PATH_JOIN
    /// <inheritdoc cref="Path.Join(ReadOnlySpan{char}, ReadOnlySpan{char})" />
    public static AbsolutePath
        Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, IFileSystem? fileSystem = null) =>
        SafePath(fileSystem).PathJoin(path1, path2);
#endif
#if FEATURE_PATH_JOIN
    /// <inheritdoc cref="Path.Join(ReadOnlySpan{char}, ReadOnlySpan{char}, ReadOnlySpan{char})" />
    public static AbsolutePath Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2,
        ReadOnlySpan<char> path3, IFileSystem? fileSystem = null) => SafePath(fileSystem).PathJoin(path1, path2, path3);
#endif
#if FEATURE_PATH_ADVANCED
    /// <inheritdoc cref="Path.Join(ReadOnlySpan{char}, ReadOnlySpan{char}, ReadOnlySpan{char}, ReadOnlySpan{char})" />
    public static AbsolutePath Join (ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3, ReadOnlySpan<char> path4, IFileSystem? fileSystem = null) => SafePath(fileSystem).PathJoin(path1, path2,path3,path4);
#endif

#if FEATURE_PATH_ADVANCED
    /// <inheritdoc cref="Path.Join(string[])" />
    public static AbsolutePath Join(IFileSystem? fileSystem = null, params string[] paths) =>
        SafePath(fileSystem).PathJoin(paths);
#endif


    private static SystemIOPath SafePath(IFileSystem? system) => (system ?? new FileSystem()).Path;
}