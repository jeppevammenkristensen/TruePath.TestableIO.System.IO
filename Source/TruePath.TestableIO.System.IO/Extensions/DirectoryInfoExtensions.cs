using TruePath;
// ReSharper
// disable CheckNamespace
namespace System.IO.Abstractions;

/// <summary>
/// Provides extension methods for <see cref="IDirectoryInfo"/> to enhance functionality
/// including the creation of subdirectories and handling absolute paths.
/// </summary>
public static partial class DirectoryInfoExtensions
{
    /// <inheritdoc cref="DirectoryInfo.CreateSubdirectory(string)" />
    public static IDirectoryInfo CreateSubdirectory(IDirectoryInfo directoryInfo,
        LocalPath path)
    {
        var result = directoryInfo.CreateSubdirectory(path.Value);
        return result;
    }
    
    /// <summary>
    /// Return the directory info as an <see cref="AbsolutePath"/>
    /// </summary>
    /// <param name="directoryInfo"></param>
    /// <returns></returns>
    public static AbsolutePath GetAbsolutePath(this IDirectoryInfo directoryInfo)
    {
        return AbsolutePath.Create(directoryInfo.FullName);
    }


    /// <inheritdoc cref="DirectoryInfo.MoveTo(string)" />
    public static void MoveTo(this IDirectoryInfo directoryInfo, AbsolutePath destDirName)
    {
        directoryInfo.MoveTo(destDirName.Value);
    }
}