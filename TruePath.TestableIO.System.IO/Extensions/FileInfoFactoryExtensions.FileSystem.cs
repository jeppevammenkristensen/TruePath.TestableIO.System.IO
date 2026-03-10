using TruePath;
using TruePath.TestableIO.System.IO;

namespace System.IO.Abstractions;

public static partial class FileInfoFactoryExtensions
{
    /// <inheritdoc cref="IFileInfoFactory.New(string)"/>
    public static IFileInfo NewFileInfo(this AbsolutePath path, IFileSystem? fileSystem = null) => FileInfoIO.New(path, fileSystem);
}