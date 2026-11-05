using System.IO.Abstractions;
using System.IO.Abstractions.TestingHelpers;
using TruePath;
using TruePath.TestableIO.System.IO;
using Xunit;

namespace TruePath.TestableIO.System.IO.Tests;

public class PathCompatibilityTests
{
    private static AbsolutePath Root => AbsolutePath.Create(OperatingSystem.IsWindows() ? @"C:\" : "/");

    [Fact]
    public void CombineOverloadsPreserveAbstractionSemantics()
    {
        var fileSystem = new MockFileSystem();
        var directory = Root / "base";
        var expected = directory / "child" / "file.txt";

        Assert.Equal(expected, fileSystem.Path.CombineToPath(directory.Value, "child/file.txt"));
        Assert.Equal(expected, fileSystem.Path.CombineToPath(directory.Value, "child", "file.txt"));
        Assert.Equal(expected, fileSystem.Path.CombineToPath(directory.Value, "child", "", "file.txt"));
        Assert.Equal(expected, fileSystem.Path.CombineToPath(new[] { directory.Value, "child", "file.txt" }));
        Assert.Equal(expected, PathIO.Combine(directory.Value, "child", "file.txt", fileSystem));
#if NET10_0_OR_GREATER
        Assert.Equal(expected, fileSystem.Path.CombineToPath(new[] { directory.Value, "child", "file.txt" }.AsSpan()));
#endif
    }

    [Fact]
    public void CombineAndJoinRejectRelativeResults()
    {
        var fileSystem = new MockFileSystem();

        Assert.Throws<ArgumentException>(() => fileSystem.Path.CombineToPath("base", "child"));
        Assert.Throws<ArgumentException>(() => fileSystem.Path.CombineToPath(new[] { "base", "child" }));
        Assert.Throws<ArgumentException>(() => fileSystem.Path.PathJoin(new[] { "base", "child" }));
        Assert.Throws<ArgumentException>(() => PathIO.Combine("base", "child", fileSystem));
    }

    [Fact]
    public void JoinOverloadsPreserveAbstractionSemantics()
    {
        var fileSystem = new MockFileSystem();
        var directory = Root / "base";
        var expected = directory / "child" / "file.txt";

        Assert.Equal(expected, fileSystem.Path.PathJoin(directory.Value.AsSpan(), "child/file.txt".AsSpan()));
        Assert.Equal(expected, fileSystem.Path.PathJoin(directory.Value.AsSpan(), "child".AsSpan(), "file.txt".AsSpan()));
        Assert.Equal(expected, fileSystem.Path.PathJoin(directory.Value.AsSpan(), "child".AsSpan(), "".AsSpan(), "file.txt".AsSpan()));
        Assert.Equal(expected, fileSystem.Path.PathJoin(new[] { directory.Value, "child", "file.txt" }));
        Assert.Equal(expected, PathIO.Join(fileSystem, directory.Value, "child", "file.txt"));
    }

    [Theory]
    [InlineData(@"\x")]
    [InlineData(@"C:x")]
    [InlineData(@"C:")]
    public void WindowsCombineRejectsPartiallyQualifiedResults(string secondPath)
    {
        if (!OperatingSystem.IsWindows()) return;
        var fileSystem = new MockFileSystem();
        var directory = AbsolutePath.Create(@"C:\base");

        Assert.Throws<ArgumentException>(() => fileSystem.Path.CombineToPath(directory.Value, secondPath));
        Assert.Throws<ArgumentException>(() => PathIO.Combine(directory.Value, secondPath, fileSystem));
        Assert.Throws<ArgumentException>(() => fileSystem.Path.PathJoin(new[] { secondPath }));
        // TruePath's operator deliberately has different semantics from IPath.Combine.
        Assert.Equal(AbsolutePath.Create(fileSystem.Path.GetFullPath(secondPath, directory.Value)), directory / secondPath);
    }

    [Fact]
    public void GetFullPathUsesInjectedCurrentDirectoryAndExplicitBase()
    {
        var current = Root / "mock-current";
        var fileSystem = new MockFileSystem(new Dictionary<string, MockFileData>(), current.Value);
        var explicitBase = Root / "explicit-base";

        Assert.Equal(current / "child", fileSystem.Path.PathGetFullPath("child"));
        Assert.Equal(current / "child", PathIO.GetFullPath("child", fileSystem));
        Assert.Equal(explicitBase / "child", PathIO.GetFullPath("child", explicitBase.Value, fileSystem));
    }

    [Theory]
    [InlineData(@"\child", @"C:\child")]
    [InlineData(@"C:child", @"C:\mock-current\child")]
    public void WindowsGetFullPathResolvesThroughInjectedFileSystem(string input, string expected)
    {
        if (!OperatingSystem.IsWindows()) return;
        var fileSystem = new MockFileSystem(new Dictionary<string, MockFileData>(), @"C:\mock-current");

        Assert.Equal(AbsolutePath.Create(expected), PathIO.GetFullPath(input, fileSystem));
    }

    [Fact]
    public void RootParentNormalizationKeepsTheRoot()
    {
        var fileSystem = new MockFileSystem();
        Assert.Equal(Root, fileSystem.Path.CombineToPath(Root.Value, "base", ".."));
        Assert.Equal(Root, fileSystem.Path.PathJoin(new[] { Root.Value, "base", ".." }));
        Assert.Equal(Root, fileSystem.Path.CombineToPath(Root.Value, ".."));
    }

    [Fact]
    public void SameDirectoryRelativePathIsDot()
    {
        var fileSystem = new MockFileSystem();
        var directory = Root / "base";
        Assert.Equal(".", fileSystem.Path.GetRelativePath(directory.Value, directory).Value);
        Assert.Equal(".", PathIO.GetRelativePath(directory.Value, directory, fileSystem).Value);
    }

    [Fact]
    public void CurrentDirectoryLocalPathCanBePassedToCreateSubdirectory()
    {
        var fileSystem = new MockFileSystem();
        var directory = Root / "base";
        var info = fileSystem.Directory.CreateDirectory(directory);

        var result = DirectoryInfoExtensions.CreateSubdirectory(info, LocalPath.Create(""));

        Assert.Equal(directory, result.GetAbsolutePath());
    }

    [Fact]
    public void ChangeExtensionRetainsSystemIOSemanticsForDotfilesAndRoots()
    {
        var fileSystem = new MockFileSystem();
        var directory = Root / "base";
        var dotfile = directory / ".gitignore";

        Assert.Equal(directory, fileSystem.Path.ChangeExtension(dotfile, null));
        Assert.Equal(directory, PathIO.ChangeExtension(dotfile, null, fileSystem));
        Assert.Throws<ArgumentException>(() => dotfile.WithExtension(null));
        Assert.Equal(Root / ".bar", PathIO.ChangeExtension(Root, "bar", fileSystem));
        Assert.Throws<ArgumentException>(() => Root.WithExtension("bar"));
        Assert.Null(PathIO.ChangeExtension((AbsolutePath?)null, "txt", fileSystem));
    }

    [Fact]
    public void FileOperationsAndEnumerationStayInsideInjectedFileSystem()
    {
        var fileSystem = new MockFileSystem();
        var directory = Root / "virtual-only";
        var file = directory / "file.txt";
        fileSystem.Directory.CreateDirectory(directory);

        FileIO.WriteAllText(file, "content", fileSystem);

        Assert.Equal("content", file.ReadAllText(fileSystem));
        Assert.Equal(new[] { file }, DirectoryIO.GetFiles(directory, "*.txt", fileSystem));
    }
}
