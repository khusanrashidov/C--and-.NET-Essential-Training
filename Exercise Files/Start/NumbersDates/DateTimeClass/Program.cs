// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for working with Dates and Times

// TODO: Use DateTime.Now property to get the current date and time
DateTime now = DateTime.Now;
Console.WriteLine(now);

// TODO: DateTime.Today gets just the current date with time set to 12:00:00 AM
DateTime today = DateTime.Today;
Console.WriteLine(today);

// TODO: DateOnly and TimeOnly represent just dates and times
DateOnly dt = DateOnly.FromDateTime(DateTime.Now);
TimeOnly tm = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine(dt);
Console.WriteLine(tm);

// TODO: Dates have properties that can be inspected
Console.WriteLine(today.DayOfWeek);
Console.WriteLine(today.DayOfYear);

// TODO: Dates also have methods to change their values
now = now.AddDays(5);
now = now.AddHours(9);
now = now.AddMonths(1);
Console.WriteLine(now);

// TODO: The TimeSpan class represents a duration of time
DateTime AprilFools = new DateTime(now.Year, 4, 1);
DateTime NewYears = new DateTime(now.Year, 1, 1);

TimeSpan interval = AprilFools - NewYears;
Console.WriteLine(interval);

// TODO: Dates can be compared using regular operators
Console.WriteLine($"{NewYears < AprilFools}");
Console.WriteLine($"{NewYears > AprilFools}");

// TODO: The DateTimeOffset class represents a date and time with an offset
DateTimeOffset dto = new DateTimeOffset(DateTime.Now);
Console.WriteLine(dto);

var dto0 = new DateTimeOffset(DateTime.Now);
Console.WriteLine(dto0);

DateTimeOffset dto1 = new(DateTime.Now);
Console.WriteLine(dto1);

Console.WriteLine(DateTimeOffset.UtcNow);
Console.WriteLine(DateTimeOffset.Now);

public class MyAnswer
{

    // Change these Boolean values to control whether you see 
    // the expected result and/or hints.
    public static Boolean ShowExpectedResult = false;
    public static Boolean ShowHints = false;

    public static int CalcHowManyDays(string date_str)
    {
        // Your code goes here.
        var now = DateTime.Now;
        if (DateTime.TryParse(date_str, out DateTime date))
        {
            TimeSpan time;

            if (now > date)
            {
                time = now - date;
                return time.Days;
            }
            else if (now < date)
            {
                time = date - now;
                return -time.Days;
            }
            else
            {
                return 0;
            }
        }

        return int.MaxValue;
    }
}

public class Answer
{

    // Change these Boolean values to control whether you see 
    // the expected result and/or hints.
    public static Boolean ShowExpectedResult = false;
    public static Boolean ShowHints = false;

    public static int CalcHowManyDays(string date_str)
    {
        // Your code goes here.
        var now = DateTime.Now;
        if (DateTime.TryParse(date_str, out DateTime date))
        {
            TimeSpan time = now - date;
            return time.Days;
        }

        return int.MaxValue;
    }
}
