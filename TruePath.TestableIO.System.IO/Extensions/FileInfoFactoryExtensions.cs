using TruePath;

namespace System.IO.Abstractions;

public static class FileInfoFactoryExtensions
{
    /// <inheritdoc cref="IFileInfoFactory.New(string)"/>
    public static IFileInfo NewFileInfo(this IFileInfoFactory factory, AbsolutePath filePath)
    {
        return factory.New(filePath.Value);
    }
}