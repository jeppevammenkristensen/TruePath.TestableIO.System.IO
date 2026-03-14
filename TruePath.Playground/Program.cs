// See https://aka.ms/new-console-template for more information

using System.IO.Abstractions;
using FileBasedApp.Toolkit;

var applicationData = Environment.SpecialFolder.ApplicationData.GetSpecialFolder();
applicationData.FindRequiredParent(x => x.FileName == "SomeValue");
var ancestors = applicationData.GetAncestors(true).ToList();

// Combining with TruePath.TestableIO.System.IO
// This was orignally part of the FileBased.Toolkit library but moved
// to it's own library
var newDirectory = applicationData / "NewDirectory";
newDirectory.CreateDirectory();
// or DirectoryIO.CreateDirectory(newDirectory);

IFileSystem fileSystem = new FileSystem();
fileSystem.File.Create(newDirectory / "test.txt");
var newFileInfo = (newDirectory / "test.txt").NewFileInfo();

// or FileIO.Create(newDirectory / "test.txt"); 

(newDirectory / "..").GetDirectories(fileSystem);
