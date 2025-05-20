// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for parsing numerical data from strings

string[] NumStrs = { "  1 ", " 1.45  ", "-100", "5e+04 " };

int testint;
float testfloat;
bool result;

// TODO: The Parse method attempts to parse a string to a number and
// throws an exception if the parse is unsuccessful
foreach (string str in NumStrs)
{
    try
    {
        testfloat = float.Parse(str);
        Console.WriteLine($"Float parsed number is {testfloat}.");
        testint = int.Parse(str);
        Console.WriteLine($"Int parsed number is {testint}.");
    }
    catch (FormatException e)
    {
        Console.WriteLine($"Could not parse '{str}': {e.Message}.");
    }
}

// TODO: Convert class methods are similar to the Parse method
foreach (string str in NumStrs)
{
    try
    {
        testfloat = Convert.ToSingle(str);
        Console.WriteLine($"Converted to float number is {testfloat}.");
        testint = Convert.ToInt32(str);
        Console.WriteLine($"Converted to int number is {testint}.");
    }
    catch (FormatException e)
    {
        Console.WriteLine($"Could not parse '{str}': {e.Message}.");
    }
}

// TODO: The TryParse method returns 'true' if the parse is successful
result = int.TryParse(NumStrs[0], out testint);
Console.WriteLine($"{result} -- '{NumStrs[0]}': {testint}");

result = float.TryParse(NumStrs[1], out testfloat);
Console.WriteLine($"{result} -- '{NumStrs[1]}': {testfloat}");

result = int.TryParse(NumStrs[2], out testint);
Console.WriteLine($"{result} -- '{NumStrs[2]}': {testint}");

result = float.TryParse(NumStrs[3], out testfloat);
Console.WriteLine($"{result} -- '{NumStrs[3]}': {testfloat}");

int test;
result = int.TryParse(NumStrs[3], out test);
Console.WriteLine($"{result} -- '{NumStrs[3]}': {test}"); // if the parse fails, the out variable is set to 0 by default
