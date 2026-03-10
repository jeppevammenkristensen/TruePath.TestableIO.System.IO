using System.IO.Abstractions;

namespace TruePath.TestableIO.System.IO;

/// <summary>
/// Add direct methods to <see cref="IFileInfo"/> convenience methods. The methods will conditionally accept a <see cref="IFileSystem"/>
/// which if not defined will default to <![CDATA[new FileSystem()]]>
/// </summary>
public class FileInfoIO
{
    /// <inheritdoc cref="IFileInfoFactory.New(string)"/>
    public static IFileInfo New(AbsolutePath path, IFileSystem? fileSystem = null) => (fileSystem ?? new FileSystem()).FileInfo.NewFileInfo(path);
}