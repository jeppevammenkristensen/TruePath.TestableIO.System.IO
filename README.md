> [!NOTE]
> `TruePath.TestableIO.System.IO` previously lived in the
> [FileBasedApp.Toolkit repository](https://github.com/jeppevammenkristensen/FileBasedApp.Toolkit).
> It has been extracted into this standalone repository together with its relevant Git history.

# TruePath.TestableIO.System.IO

[![NuGet](https://img.shields.io/nuget/v/TruePath.TestableIO.System.IO.svg?style=flat-square&label=NuGet)](https://www.nuget.org/packages/TruePath.TestableIO.System.IO)

`TruePath.TestableIO.System.IO` bridges
[TruePath](https://github.com/ForNeVeR/TruePath) and
[System.IO.Abstractions](https://github.com/TestableIO/System.IO.Abstractions).
It lets applications use TruePath's strongly typed `AbsolutePath` with testable file-system
abstractions instead of converting paths to strings at every call site.

The package targets .NET 8 and .NET 10.

## Installation

Install the package from NuGet:

```shell
dotnet add package TruePath.TestableIO.System.IO
```

## Features

The library provides three complementary ways to work with paths and file-system abstractions:

- Extensions on interfaces such as `IFile`, `IDirectory`, and `IFileInfo` that accept
  `AbsolutePath`.
- Extensions on `AbsolutePath` for direct file-system operations. These accept an optional
  `IFileSystem`, making the same call convenient in production and test code.
- Static entry points such as `FileIO`, `DirectoryIO`, and `PathIO` for callers that prefer
  explicit helper classes.

When an operation name would be ambiguous, the path extension identifies the target. For
example, `Exists` becomes `FileExists` or `DirectoryExists`, and `Create` becomes `FileCreate`
or `DirectoryCreate`.

## Usage

```csharp
using System.IO.Abstractions;
using TruePath;
using TruePath.TestableIO.System.IO;

IFileSystem fileSystem = new FileSystem();
var path = AbsolutePath.Create("/var/log/app.log");

// An IFile extension that accepts AbsolutePath.
fileSystem.File.WriteAllText(path, "Hello from TruePath");

// An AbsolutePath extension with an injectable file system.
path.WriteAllText("Hello from a testable file system", fileSystem);

// The equivalent static helper.
FileIO.WriteAllText(path, "Hello from FileIO", fileSystem);
```

If no `IFileSystem` is supplied to an `AbsolutePath` extension or static helper, the operation
uses a new `FileSystem` instance:

```csharp
var exists = path.FileExists();
var logDirectory = AbsolutePath.Create("/var/log");
var directoryExists = logDirectory.DirectoryExists();
```

## API pattern

For a typical `System.IO.Abstractions` operation, the package exposes overloads following this
pattern:

```text
IFile.WriteAllText(AbsolutePath path, string? contents)
AbsolutePath.WriteAllText(string? contents, IFileSystem? fileSystem = null)
FileIO.WriteAllText(AbsolutePath path, string? contents, IFileSystem? fileSystem = null)
```

The exact available operations depend on the target framework and the corresponding
`System.IO` APIs.

## TruePath 2.0 compatibility

This package requires TruePath 2.0.0 or later. Public wrapper signatures are unchanged,
but path normalization and validation follow TruePath 2.0.

- **Combine and Join do not resolve paths.** `IPath.CombineToPath`, `IPath.PathJoin`,
  `PathIO.Combine`, and `PathIO.Join` retain the injected `IPath`'s System.IO semantics.
  Their result must be fully qualified, otherwise `ArgumentException` is thrown.
  On Windows, `\x`, `C:x`, and `C:` are not fully qualified.
- **TruePath's `/` operator is different.** On Windows, combining `C:\base` and `\x`
  through `IPath.Combine` yields `\x`, so `CombineToPath` rejects it. TruePath's
  `AbsolutePath / LocalPath` instead yields `C:\x`. The bridge deliberately does not
  substitute `/` for the injected abstraction's Combine or Join operations.
- **Resolve explicitly through the abstraction.** Use `PathIO.GetFullPath(input, fileSystem)`
  to use the injected filesystem's current directory, or the overload with an explicit
  base path for deterministic resolution. Do not catch validation failures and silently
  fall back to the real process current directory.
- **The current-directory `LocalPath` is `"."`.** `GetRelativePath` for identical paths
  returns a `LocalPath` whose `Value` is `"."`, not an empty string. Mocks expecting a
  `LocalPath.Value` argument may need updating, including `CreateSubdirectory` callers.
- **ChangeExtension keeps System.IO behavior.** It delegates to `IPath.ChangeExtension`,
  not TruePath's stricter `WithExtension`. Removing the extension of a dotfile can still
  return its parent directory, and changing an extension on a root can produce a file
  under that root; `WithExtension` rejects those operations.
- **Enumeration remains injectable.** Use `DirectoryIO.GetFiles(path, pattern, fileSystem)`
  or the abstraction overloads when testing. TruePath.SystemIo's new
  `GetFiles(LocalPathPattern)` overload accesses the real filesystem instead.

For example, resolve a user-supplied path against a known base directory:

```csharp
var resolved = PathIO.GetFullPath(input, baseDirectory.Value, fileSystem);
var content = resolved.ReadAllText(fileSystem);
```

TruePath's fixes to root normalization also apply to returned paths: `C:\base\..`
normalizes to `C:\` on Windows and `/base/..` to `/` on Unix. Changes to `ReadKind`,
`Canonicalize`, and prefix comparisons affect direct TruePath calls, but the bridge
does not call those APIs internally.

## Regression tests

From the repository root, run:

```shell
dotnet test Tests/TruePath.TestableIO.System.IO.Tests/TruePath.TestableIO.System.IO.Tests.csproj --configuration Release
```

The tests target .NET 8 and .NET 10 and use `MockFileSystem`, not real filesystem I/O.
Run on both Windows and Unix to cover platform-specific path behavior; Windows-only
cases return without executing their assertions on other platforms.

## Preview packages

Preview versions may be published to GitHub Packages before release to NuGet.org. Add the
GitHub NuGet source to consume them:

```shell
dotnet nuget add source "https://nuget.pkg.github.com/jeppevammenkristensen/index.json" \
  --name github \
  --username YOUR_GITHUB_USERNAME \
  --password YOUR_GITHUB_PAT \
  --store-password-in-clear-text
```

The personal access token needs the `read:packages` scope. See GitHub's
[personal access token documentation](https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/managing-your-personal-access-tokens)
for setup instructions.

## Building locally

```shell
dotnet restore Source/TruePath.TestableIO.System.IO/TruePath.TestableIO.System.IO.csproj
dotnet build Source/TruePath.TestableIO.System.IO/TruePath.TestableIO.System.IO.csproj --configuration Release
```

Create a NuGet package with:

```shell
dotnet pack Source/TruePath.TestableIO.System.IO/TruePath.TestableIO.System.IO.csproj --configuration Release
```

## Contributing

Bug reports and pull requests are welcome. When adding an operation, keep the available API
shapes consistent: prefer an abstraction-interface overload, an `AbsolutePath` extension, and
a static helper where the underlying API supports them.

## Note on AI-assisted development

AI has been used to help generate documentation and simple development tasks. The extension
methods themselves were generated by a purpose-built Roslyn tool that analyzed the
System.IO.Abstractions source API.
