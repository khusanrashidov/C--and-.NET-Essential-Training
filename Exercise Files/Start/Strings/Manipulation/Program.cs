﻿// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for manipulating string content

string str1 = "The quick brown fox jumps over the lazy dog.";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = { "one", "two", "three", "four" };

Console.WriteLine($"{str1}");

// TODO: Length of a string 
Console.WriteLine(str1.Length);

// TODO: Access individual characters
Console.WriteLine(str1[14]);

// TODO: Iterate over a string like any other sequence of values
foreach (char ch in str1)
{
    Console.Write(ch);
    if (ch == 'b')
    {
        Console.WriteLine();
        break;
    }
}

// TODO: String Concatenation         
string outstr;
outstr = string.Concat(strs);
Console.WriteLine(outstr);

// TODO: Joining strings together with Join
outstr = string.Join('.', strs);
Console.WriteLine(outstr);
outstr = string.Join("---", strs);
Console.WriteLine(outstr);

// TODO: String Comparison
bool isNotEqual = str2.Equals(str3);
Console.WriteLine($"{isNotEqual}");
bool isEqual = str2.Equals(str3, StringComparison.OrdinalIgnoreCase);
Console.WriteLine($"{isEqual}");
// Equals just returns a regular Boolean

// Compare will perform an ordinal comparison and return:
// < 0 : first string comes before second in sort order
// 0 : first and second strings are same position in sort order
// > 0 : first string comes after the second in sort order
int result = string.Compare(str2, "This is a string");
Console.WriteLine($"{result}");

// TODO: Replacing content
outstr = str1.Replace("fox", "cat");
Console.WriteLine(outstr);
