using System.Diagnostics.CodeAnalysis;
using TruePath;

namespace System.IO.Abstractions;

public static partial class PathExtensions
{
    /// <inheritdoc cref="Path.EndsInDirectorySeparator(string)" />
    public static bool EndsInDirectorySeparator (this AbsolutePath path, IPath source, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Path.EndsInDirectorySeparator(path);  
    }
    
    /// <inheritdoc cref="Path.Exists(string)" />
    public static bool PathExists ([NotNullWhen(true)] this AbsolutePath path, IPath source, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Path.Exists(path);
        
    }
    
    /// <inheritdoc cref="Path.Exists(string)" />
    public static bool PathExists ([NotNullWhen(true)] this AbsolutePath? path, IPath source, IFileSystem? fileSystem = null)
    {
        fileSystem ??= new FileSystem();
        return fileSystem.Path.Exists(path);
        
    }
}