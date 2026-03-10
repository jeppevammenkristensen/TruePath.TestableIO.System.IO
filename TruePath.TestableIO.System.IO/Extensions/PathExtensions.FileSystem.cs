using System.Diagnostics.CodeAnalysis;
using TruePath;
using TruePath.TestableIO.System.IO;

namespace System.IO.Abstractions;

public static partial class PathExtensions
{
    /// <inheritdoc cref="Path.EndsInDirectorySeparator(string)" />
    public static bool EndsInDirectorySeparator (this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Path.EndsInDirectorySeparator(path);  
    }
    
    /// <inheritdoc cref="Path.Exists(string)" />
    public static bool PathExists ([NotNullWhen(true)] this AbsolutePath path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Path.Exists(path);
    }
    
    /// <inheritdoc cref="Path.Exists(string)" />
    public static bool PathExists ([NotNullWhen(true)] this AbsolutePath? path, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Path.Exists(path);
    }
    
    /// <inheritdoc cref = "Path.GetPathRoot(string? )"/>
    public static AbsolutePath? GetPathRoot(AbsolutePath? path, IFileSystem? fileSystem = null) =>
        PathIO.GetPathRoot(path, fileSystem);
    
    /// <inheritdoc cref = "Path.HasExtension(string)"/>
    public static bool HasExtension(AbsolutePath path, IFileSystem? fileSystem = null) => PathIO.HasExtension(path, fileSystem);

    /// <inheritdoc cref = "Path.HasExtension(string)"/>
    public static bool HasExtension([NotNullWhen(true)] AbsolutePath? path, IFileSystem? fileSystem = null) => PathIO.HasExtension(path, fileSystem);
}