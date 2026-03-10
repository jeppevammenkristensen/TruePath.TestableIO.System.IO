using TruePath;

namespace System.IO.Abstractions;

/// <summary>
/// Provides extension methods for the <see cref="IFileInfoFactory"/> interface
/// to create instances of <see cref="IFileInfo"/> using an <see cref="AbsolutePath"/>.
/// </summary>
public static partial class FileInfoFactoryExtensions
{
    /// <inheritdoc cref="IFileInfoFactory.New(string)"/>
    public static IFileInfo New(this IFileInfoFactory factory, AbsolutePath filePath)
    {
        return factory.New(filePath.Value);
    }
}