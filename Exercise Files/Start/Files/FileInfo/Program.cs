// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Working with file information

// Make sure the example file exists
const string filename = "TextFile.txt";

if (!File.Exists(filename))
{
    using (StreamWriter sw = File.CreateText(filename))
    {
        sw.WriteLine("This is a text file.");
    }
}

// TODO: Get some information about the file
Console.WriteLine(File.GetCreationTime(filename));
Console.WriteLine(File.GetLastWriteTime(filename));
Console.WriteLine(File.GetLastAccessTime(filename));

File.SetAttributes(filename, FileAttributes.ReadOnly);
Console.WriteLine(File.GetAttributes(filename));

// TODO: We can also get general information using a FileInfo 
try
{
    FileInfo fi = new(filename);
    Console.WriteLine(fi.FullName);
    Console.WriteLine(fi.Name);
    Console.WriteLine(fi.Length);
    Console.WriteLine(fi.Attributes);
    Console.WriteLine(fi.CreationTime);
    Console.WriteLine(fi.Directory);
    Console.WriteLine(fi.DirectoryName);
    Console.WriteLine(fi.IsReadOnly);
    Console.WriteLine(fi.LastAccessTime);
    Console.WriteLine(fi.LastWriteTime);
}
catch (Exception e)
{
    Console.WriteLine(e);
    Console.WriteLine(e.Message);
    Console.WriteLine(e.ToString());
}

// TODO: File information can also be manipulated
var dt = new DateTime(2002, 08, 08, 18, 08, 20);
File.SetAttributes(filename, FileAttributes.Normal);
File.SetCreationTime(filename, dt);
File.SetLastWriteTime(filename, dt);
File.SetLastAccessTime(filename, dt);

Console.WriteLine(File.GetAttributes(filename));
Console.WriteLine(File.GetCreationTime(filename));
Console.WriteLine(File.GetLastWriteTime(filename));
Console.WriteLine(File.GetLastAccessTime(filename));
