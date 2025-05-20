const string dirName = "FileCollection";
const string filePath = "result.txt";

var files = new List<string>(Directory.EnumerateFileSystemEntries(dirName));
long wordCount = 0, wordSize = 0;
long excelCount = 0, excelSize = 0;
long powerPointCount = 0, powerPointSize = 0;


foreach (string file in files)
{
    FileInfo fi = new(file);
    if (file.EndsWith(".docx"))
    {
        wordCount++;
        wordSize += fi.Length;
    }
    else if (file.EndsWith(".xlsx"))
    {
        excelCount++;
        excelSize += fi.Length;
    }
    else if (file.EndsWith(".pptx"))
    {
        powerPointCount++;
        powerPointSize += fi.Length;
    }
}

using StreamWriter sw = File.CreateText(filePath);
sw.WriteLine("~~~~ Results ~~~~");
sw.WriteLine($"Total Files: {wordCount + excelCount + powerPointCount}");
sw.WriteLine($"Word Count: {wordCount}");
sw.WriteLine($"Excel Count: {excelCount}");
sw.WriteLine($"PowerPoint Count: {powerPointCount}");
sw.WriteLine("----");
sw.WriteLine($"Total Size: {wordSize + excelSize + powerPointSize:N0}");
sw.WriteLine($"Word Size: {wordSize:N0}");
sw.WriteLine($"Excel Size: {excelSize:N0}");
sw.WriteLine($"PowerPoint Size: {powerPointSize:N0}");
