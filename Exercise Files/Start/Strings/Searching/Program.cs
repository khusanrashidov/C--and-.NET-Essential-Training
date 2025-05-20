// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for searching string content

string teststr = "The quick brown Fox jumps over the lazy Dog";

// TODO: Contains determines whether a string contains certain content
Console.WriteLine($"{teststr.Contains("fox")}");
Console.WriteLine($"{teststr.Contains("fox", StringComparison.CurrentCultureIgnoreCase)}");
//Console.WriteLine($"{teststr.Contains("fox", StringComparer.CurrentCultureIgnoreCase)}"); // error

// TODO: StartsWith and EndsWith determine if a string starts 
// or ends with a given test string
Console.WriteLine($"{teststr.StartsWith("the")}");
Console.WriteLine($"{teststr.StartsWith("the", StringComparison.CurrentCultureIgnoreCase)}");
Console.WriteLine($"{teststr.EndsWith("dog")}");
Console.WriteLine($"{teststr.EndsWith("dog", StringComparison.CurrentCultureIgnoreCase)}");

// TODO: IndexOf, LastIndexOf finds the index of a substring
Console.WriteLine($"{teststr.IndexOf("the")}");
Console.WriteLine($"{teststr.LastIndexOf("the")}");
Console.WriteLine($"{teststr.IndexOf("the", StringComparison.CurrentCultureIgnoreCase)}");
Console.WriteLine($"{teststr.LastIndexOf("the", StringComparison.CurrentCultureIgnoreCase)}");

// TODO: Determining empty, null, or whitespace
string str0;
string str1 = null;
string str2 = "   ";
string str3 = string.Empty;
//Console.WriteLine($"{string.IsNullOrEmpty(str0)}"); // use of unassigned variable
Console.WriteLine($"{string.IsNullOrEmpty(str1)}");
Console.WriteLine($"{string.IsNullOrEmpty(str3)}");
Console.WriteLine($"{string.IsNullOrWhiteSpace(str2)}");
