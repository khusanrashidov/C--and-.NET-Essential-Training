// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Directories

const string dirname = "TestDir";

// TODO: Create a Directory if it doesn't already exist
if (!Directory.Exists(dirname))
{
    Directory.CreateDirectory(dirname);
}
else
{
    Directory.Delete(dirname);
}

// TODO: Get the path for the current directory
string curpath = Directory.GetCurrentDirectory();
Console.WriteLine(curpath);

// TODO: Just like with files, you can retrieve info about a directory
var di = new DirectoryInfo(curpath);
Console.WriteLine(di.Name);
Console.WriteLine(di.FullName);
Console.WriteLine(di.Root);
Console.WriteLine(di.Parent);
Console.WriteLine(di.CreationTime);
Console.WriteLine(di.LastWriteTime);
Console.WriteLine(di.LastAccessTime);
Console.WriteLine(di.Attributes);

// TODO: Enumerate the contents of directories
Console.WriteLine("Just directories:");
var dirs = new List<string>(Directory.EnumerateDirectories(curpath));
foreach (string dir in dirs)
{
    Console.WriteLine(dir);
}

Console.WriteLine("---------------");

Console.WriteLine("Just files:");
dirs = new List<string>(Directory.EnumerateFiles(curpath));
foreach (string dir in dirs)
{
    Console.WriteLine(dir);
}

Console.WriteLine("---------------");

Console.WriteLine("All directory contents:");
dirs = new List<string>(Directory.EnumerateFileSystemEntries(curpath));
foreach (string dir in dirs)
{
    Console.WriteLine(dir);
}
