// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for parsing dates from strings

// Collection of various date string formats to attempt parsing
string[] sampleDateTimes = {
    "January 1, 2025 9:30 AM",
    "1/1/2025",
    "Jan 1, 2025 7:30PM",
    "Jan 1, 25",
    "1/2025",
    "1/1 7PM",
    "Jan 1 '15",
};

foreach (string datestr in sampleDateTimes)
{
    // TODO: Use the static class function TryParse to try parsing the dates
    if (DateTime.TryParse(datestr, out DateTime result)) // inlined DateTime variable
    {
        Console.WriteLine($"{datestr,-28} gets parsed as: {result,+01}");
        //Console.WriteLine(result.ToString());
    }
    else
    {
        Console.WriteLine($"{datestr} could not be parsed.");
    }
}
