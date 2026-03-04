using TruePath;
// ReSharper disable CheckNamespace

namespace System.IO.Abstractions;

/// <summary>
/// Provides extension methods for the <see cref="IDirectoryInfoFactory"/> type to create
/// <see cref="IDirectoryInfo"/> instances using an <see cref="AbsolutePath"/> parameter.
/// </summary>
public static partial class DirectoryInfoFactoryExtensions
{
    /// <summary>
    ///  Initializes a new instance of a wrapper for <see cref="DirectoryInfo" /> which implements
    /// <see cref="IDirectoryInfo" />.
    /// </summary>
    /// <param name="directoryInfoFactory"></param>
    /// <param name="path">A string specifying the path on which to create the <see cref="IDirectoryInfo" />.</param>
    public static IDirectoryInfo New(this IDirectoryInfoFactory directoryInfoFactory,
        AbsolutePath path)
    {
        var result = directoryInfoFactory.New(path.Value);
        return result;
    }
}




