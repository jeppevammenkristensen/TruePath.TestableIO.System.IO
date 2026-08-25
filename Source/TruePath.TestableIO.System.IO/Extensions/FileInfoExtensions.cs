using TruePath;

namespace System.IO.Abstractions;

/// <summary>
/// Provides extension methods for the <see cref="FileInfo"/> class to enhance file manipulation capabilities.
/// </summary>
/// <remarks>
/// This static class extends the functionality of the <see cref="FileInfo"/> class by providing
/// additional utility methods for common file operations. The methods in this class are designed
/// to simplify file handling tasks and provide convenient shortcuts for frequently used operations.
/// All methods are implemented as extension methods and can be called directly on any <see cref="FileInfo"/> instance.
/// </remarks>
public static class FileInfoExtensions
{
    extension(IFileInfo fileInfo)
    {
        /// <inheritdoc cref="FileInfo.CopyTo(string)" />
        public IFileInfo CopyTo(AbsolutePath destFileName)
        {
            return fileInfo.CopyTo(destFileName.Value);
        }

        /// <inheritdoc cref="FileInfo.CopyTo(string, bool)" />
        public IFileInfo CopyTo(AbsolutePath destFileName, bool overwrite)
        {
            return fileInfo.CopyTo(destFileName.Value, overwrite);
        }

        /// <inheritdoc cref="FileInfo.MoveTo(string)" />
        public void MoveTo(AbsolutePath destFileName)
        {
            fileInfo.MoveTo(destFileName.Value);
        }
        
#if FEATURE_FILE_MOVETO_OVERWRITE
        /// <inheritdoc cref="FileInfo.MoveTo(string, bool)" />
        public void MoveTo(AbsolutePath destFileName, bool overwrite)
        {
            fileInfo.MoveTo(destFileName.Value, overwrite);
        }
    #endif

        /// <inheritdoc cref="FileInfo.Replace(string, string?)" />
        public IFileInfo Replace(AbsolutePath destinationFileName,
            AbsolutePath? destinationBackupFileName)
        {
            return fileInfo.Replace(destinationFileName.Value, destinationBackupFileName?.Value);
        }

        /// <inheritdoc cref="FileInfo.Replace(string, string?, bool)" />
        public IFileInfo Replace(AbsolutePath destinationFileName,
            AbsolutePath? destinationBackupFileName,
            bool ignoreMetadataErrors)
        {
            return fileInfo.Replace(destinationFileName.Value, destinationBackupFileName?.Value, ignoreMetadataErrors);
        }
    }
}