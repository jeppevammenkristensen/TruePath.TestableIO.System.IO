using System.Diagnostics.CodeAnalysis;
using TruePath;
// ReSharper disable CheckNamespace

namespace System.IO.Abstractions;

internal static class AbsolutePathExtensions
{
    public static AbsolutePath? AsAbsolutePath(this string? path)
    {
        return path == null ? null : AbsolutePath.Create(path);
    }
}

/// <summary>
/// Provides a set of extension methods for working with file and directory paths using the <see cref="System.IO.Abstractions.IPath"/> abstraction.
/// </summary>
/// <remarks>This is included for consistency. But a large amount these can be solved by using build in functionality of AbsolutePath</remarks>
public static partial class PathExtensions
{
    /// <inheritdoc cref = "Path.ChangeExtension(string, string)"/>
    [return: NotNullIfNotNull("path")]
    public static AbsolutePath? ChangeExtension(this IPath source, AbsolutePath? path, string? extension)
    {
        var result = source.ChangeExtension(path?.Value, extension);
        return result.AsAbsolutePath();
    }
 
    /// <inheritdoc cref = "Path.ChangeExtension(string, string)"/>
    public static AbsolutePath? ChangeExtension(this IPath source, AbsolutePath path, string? extension)
    {
        var result = source.ChangeExtension(path.Value, extension);
        return result.AsAbsolutePath();
    }

    /// <inheritdoc cref = "Path.Combine(string, string)"/>
    public static AbsolutePath Combine(this IPath source, string path1, string path2)
    {
        var result = source.Combine(path1, path2);
        return AbsolutePath.Create(result);
    }

    /// <inheritdoc cref = "Path.Combine(string, string, string)"/>
    public static AbsolutePath Combine(this IPath source, string path1, string path2, string path3)
    {
        var result = source.Combine(path1, path2, path3);
        return AbsolutePath.Create(result);
    }

    /// <inheritdoc cref = "Path.Combine(string, string, string, string)"/>
    public static AbsolutePath Combine(this IPath source,string path1, string path2, string path3, string path4)
    {
        var result = source.Combine(path1, path2, path3, path4);
        return AbsolutePath.Create(result);
    }

    /// <inheritdoc cref = "Path.Combine(string[])"/>
    public static AbsolutePath Combine(this IPath source, string[] paths)
    {
        var result = source.Combine(paths);
        return AbsolutePath.Create(result);
    }

#if FEATURE_PATH_SPAN
    /// <inheritdoc cref="Path.Combine(ReadOnlySpan{string})" />
    public static AbsolutePath Combine (this IPath source, ReadOnlySpan<string> paths)
    {
        var result = source.Combine(paths);
        return AbsolutePath.Create(result);
    }
#endif

#if FEATURE_PATH_ADVANCED
    /// <inheritdoc cref="Path.EndsInDirectorySeparator(string)" />
    public static bool EndsInDirectorySeparator (this IPath source, AbsolutePath path)
    {
        var result = source.EndsInDirectorySeparator(path.Value);
        return result;
    }
#endif
#if FEATURE_FILESYSTEM_NET_7_OR_GREATER
   
    /// <inheritdoc cref="Path.Exists(string)" />
    public static bool Exists (this IPath source, [NotNullWhen(true)] AbsolutePath path)
    {
        var result = source.Exists(path.Value);
        return result;
    }
    
    
    /// <inheritdoc cref="Path.Exists(string)" />
    public static bool Exists (this IPath source, [NotNullWhen(true)] AbsolutePath? path)
    {
        var result = source.Exists(path?.Value);
        return result;
    }
#endif

    /// <inheritdoc cref = "Path.GetDirectoryName(string)"/>
    public static AbsolutePath? GetDirectoryName(this IPath source, AbsolutePath? path)
    {
        var result = source.GetDirectoryName(path?.Value);
        return result.AsAbsolutePath();
    }


    /// <inheritdoc cref = "Path.GetExtension(string)"/>
    [return: NotNullIfNotNull("path")]
    public static AbsolutePath? GetExtension(this IPath source, AbsolutePath? path)
    {
        var result = source.GetExtension(path?.Value);
        return result.AsAbsolutePath();
    }

    /// <inheritdoc cref = "Path.GetFileName(string)"/>
    [return: NotNullIfNotNull("path")]
    public static AbsolutePath? GetFileName(this IPath source, AbsolutePath? path)
    {
        var result = source.GetFileName(path?.Value);
        return result.AsAbsolutePath();
    }

    /// <inheritdoc cref = "Path.GetFileNameWithoutExtension(string)"/>
    [return: NotNullIfNotNull("path")]
    public static AbsolutePath? GetFileNameWithoutExtension(this IPath source, AbsolutePath? path)
    {
        var result = source.GetFileNameWithoutExtension(path?.Value);
        return result.AsAbsolutePath();
    }

    /// <inheritdoc cref = "Path.GetFullPath(string)"/>
    public static AbsolutePath GetFullPath(this IPath source, LocalPath path)
    {
        var result = source.GetFullPath(path.Value);
        return AbsolutePath.Create(result);
    }

#if FEATURE_PATH_RELATIVE
    /// <inheritdoc cref="Path.GetFullPath(string, string)" />
    public static AbsolutePath GetFullPath (this IPath source, LocalPath path, string basePath)
    {
        var result = source.GetFullPath(path.Value,basePath);
        return AbsolutePath.Create(result);
    }
#endif

    /// <inheritdoc cref = "Path.GetPathRoot(string? )"/>
    public static AbsolutePath? GetPathRoot(this IPath source, AbsolutePath? path)
    {
        var result = source.GetPathRoot(path?.Value);
        return result.AsAbsolutePath();
    }
   

#if FEATURE_PATH_RELATIVE
    /// <inheritdoc cref="Path.GetRelativePath(string, string)" />
    public static LocalPath GetRelativePath (this IPath source, string relativeTo, AbsolutePath path)
    {
        var result = source.GetRelativePath(relativeTo,path.Value);
        return LocalPath.Create(result);
    }
#endif

    /// <summary>
    /// This uses the approach defined in <see cref="Path.GetTempFileName()"/> to use
    /// GetTempPath and GetRandomFile 
    /// </summary>
    ///<inheritdoc cref = "Path.GetTempFileName()"/>
    public static AbsolutePath GetTempFileAbsolute (this IPath source)
    {
        var result = source.GetTempPathAbsolute() / source.GetRandomFileName();
        return result;
    }
    
    /// <inheritdoc cref = "Path.GetTempPath()"/>
    public static AbsolutePath GetTempPathAbsolute(this IPath source)
    {
        var result = source.GetTempPath();
        return AbsolutePath.Create(result);
    }


    /// <inheritdoc cref = "Path.HasExtension(string)"/>
    public static bool HasExtension(this IPath source, AbsolutePath path)
    {
        return HasExtension(source, new AbsolutePath?(path));
    }

    /// <inheritdoc cref = "Path.HasExtension(string)"/>
    public static bool HasExtension(this IPath source, [NotNullWhen(true)] AbsolutePath? path)
    {
        var result = source.HasExtension(path?.Value);
        return result;
    }

#if FEATURE_SPAN
    /// <inheritdoc cref="Path.IsPathFullyQualified(ReadOnlySpan{char})" />
    public static bool IsPathFullyQualified (this IPath source, AbsolutePath path)
    {
        var result = source.IsPathFullyQualified(path.Value);
        return result;}
#endif

#if FEATURE_SPAN
    /// <inheritdoc cref="Path.IsPathRooted(ReadOnlySpan{char})" />
    public static bool IsPathRooted (this IPath source, AbsolutePath path)
    {
        var result = source.IsPathRooted(path.Value);
        return result;}
#endif
    
#if FEATURE_PATH_JOIN
    /// <inheritdoc cref="Path.Join(ReadOnlySpan{char}, ReadOnlySpan{char})" />
    public static AbsolutePath Join (this IPath source, AbsolutePath path1, AbsolutePath path2)
    {
        var result = source.Join(path1.Value,path2.Value);
        return AbsolutePath.Create(result);
    }
#endif
#if FEATURE_PATH_JOIN
    /// <inheritdoc cref="Path.Join(ReadOnlySpan{char}, ReadOnlySpan{char}, ReadOnlySpan{char})" />
    public static AbsolutePath Join (this IPath source, AbsolutePath path1, AbsolutePath path2, AbsolutePath path3)
    {
        var result = source.Join(path1.Value,path2.Value,path3.Value);
        return AbsolutePath.Create(result);
    }
#endif
#if FEATURE_PATH_ADVANCED
    /// <inheritdoc cref="Path.Join(ReadOnlySpan{char}, ReadOnlySpan{char}, ReadOnlySpan{char}, ReadOnlySpan{char})" />
    public static AbsolutePath Join (this IPath source, AbsolutePath path1, AbsolutePath path2, AbsolutePath path3, AbsolutePath path4)
    {
        var result = source.Join(path1.Value,path2.Value,path3.Value,path4.Value);
        return AbsolutePath.Create(result);
    }
#endif

#if FEATURE_PATH_ADVANCED
    /// <inheritdoc cref="Path.Join(string[])" />
    public static AbsolutePath Join (this IPath source, params IEnumerable<AbsolutePath> paths)
    {
        var result = source.Join(paths.Select(x => x.Value).ToArray());
        return AbsolutePath.Create(result);
    }
#endif


#if FEATURE_PATH_ADVANCED
    /// <inheritdoc cref="Path.TrimEndingDirectorySeparator(string)" />
    public static AbsolutePath TrimEndingDirectorySeparator (this IPath source, AbsolutePath path)
    {
        var result = source.TrimEndingDirectorySeparator(path.Value);
        return AbsolutePath.Create(result);
    }
#endif


}