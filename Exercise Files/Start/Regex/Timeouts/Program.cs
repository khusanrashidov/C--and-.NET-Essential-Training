// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Using Timeout settings for RegEx in .NET
using System.Diagnostics;
using System.Text.RegularExpressions;

const string thestr = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

// Use a Stopwatch to show elapsed time
Stopwatch sw;

// TODO: Use a Timeout value when executing RegEx to guard against bad input
const int MAX_REGEX_TIME = 1000; // 1000ms = 1 second
TimeSpan timeout = TimeSpan.FromMilliseconds(MAX_REGEX_TIME);

// Run the expression and output the result
try
{
    sw = Stopwatch.StartNew();
    Regex CapWords = new Regex(@"(a+a+)+b", RegexOptions.None, timeout);
    MatchCollection mc = CapWords.Matches(thestr);
    sw.Stop();
    Console.WriteLine($"Found {mc.Count} matches in {sw.Elapsed} time:");
    foreach (Match match in mc)
    {
        Console.WriteLine($"'{match.Value}' found at position {match.Index}");
    }
}
catch (RegexMatchTimeoutException e)
{
    Console.WriteLine(e);
    Console.WriteLine($"The RegEx took too long to execute! Elapsed time exceeded: {e.MatchTimeout}.");
}
