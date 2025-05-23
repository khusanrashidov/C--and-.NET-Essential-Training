﻿// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for Replacing content with Regexes 
using System.Text.RegularExpressions;

string teststr1 = "The quick brown Fox jumps over the lazy Dog";

Regex CapWords = new Regex(@"[A-Z]\w+");

// TODO: Regular expressions can be used to replace content in strings
// in addition to just searching for content
string str = CapWords.Replace(teststr1, "***");
Console.WriteLine(teststr1);
Console.WriteLine(str);

// TODO: Replacement text can be generated on the fly using MatchEvaluator
// This is a delegate that computes the new value of the replacement
string upperstr = CapWords.Replace(teststr1, new MatchEvaluator(
    (Match m) =>
    {
        if (m.Index == 0)
        {
            return m.Value;
        }
        return m.ToString().ToUpper();
    }));
Console.WriteLine(teststr1);
Console.WriteLine(upperstr);
