// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for formatting date information
using System.Globalization;

// Define a date
DateTime AprFools = new DateTime(2025, 4, 1, 13, 23, 30, DateTimeKind.Utc);

// TODO: 'd' Short date: mm/dd/yyyy (or dd/mm depending on locale)
Console.WriteLine($"d (short date): {AprFools:d}");

// TODO: 'D' Full date: mm/dd/yyyy (or dd/mm depending on locale)
Console.WriteLine($"D (long date): {AprFools:D}");

// TODO: 'f' Full date, short time
Console.WriteLine($"f (full short date/time): {AprFools:f}");

// TODO: 'F' Full date, long time
Console.WriteLine($"F (full long date/time): {AprFools:F}");

// TODO: 'g' General date and short time
Console.WriteLine($"g (general short date/time): {AprFools:g}");

// TODO: 'G' General date and long time
Console.WriteLine($"G (general long date/time): {AprFools:G}");

// TODO: 'm' Month and day
Console.WriteLine($"m (month day): {AprFools:m}");

// TODO: 'M' Month and day
Console.WriteLine($"M (month day): {AprFools:M}");

// TODO: 'o' Round-trip date/time pattern, ISO 8601 format
Console.WriteLine($"o (round-trip date/time): {AprFools:o}");

// TODO: 'O' Round-trip date/time pattern, ISO 8601 format
Console.WriteLine($"O (round-trip date/time): {AprFools:O}");

// TODO: 'r' RFC1123 pattern
Console.WriteLine($"r (rfc1123 date/time): {AprFools:r}");

// TODO: 'R' RFC1123 pattern
Console.WriteLine($"R (rfc1123 date/time): {AprFools:R}");

// TODO: 's' Sortable date/time pattern
Console.WriteLine($"s (sortable date/time): {AprFools:s}");

// TODO: 'S' Sortable date/time pattern
//Console.WriteLine($"S (sortable date/time): {AprFools:S}"); // throws System.FormatException

// TODO: 't' Short time
Console.WriteLine($"t (short time): {AprFools:t}");

// TODO: 'T' Long time
Console.WriteLine($"T (long time): {AprFools:T}");

// TODO: 'u' Universal sortable date/time pattern, UTC
Console.WriteLine($"u (universal sortable date/time): {AprFools:u}");

// TODO: 'U' Universal full date/time pattern, UTC
Console.WriteLine($"U (universal full date/time): {AprFools:U}");

// TODO: 'y' Year and month
Console.WriteLine($"y (year month): {AprFools:y}");

// TODO: 'Y' Year and month
Console.WriteLine($"Y (year month): {AprFools:Y}");

// any other character throws a format exception
//Console.WriteLine($"k (any character): {AprFools:k}"); // throws FormatException

// TODO: Format using a specific CultureInfo locale
Console.WriteLine(AprFools.ToString("d", CultureInfo.CreateSpecificCulture("de-DE")));

// TODO: Defining custom date and time formats
Console.WriteLine(AprFools.ToString("yyyy-MM-dd HH:mm:ss"));
Console.WriteLine(AprFools.ToString("yyyy-MM-dd HH:mm:ss.fff"));
Console.WriteLine(AprFools.ToString("yyyy-MM-dd HH:mm:ss.fffffff"));
Console.WriteLine(AprFools.ToString("yyyy-MM-dd HH:mm:ss.fffffff zzz"));
Console.WriteLine(AprFools.ToString("yyyy-MM-dd HH:mm:ss.fffffff zzz K"));
Console.WriteLine(AprFools.ToString("yyyy-MM-dd HH:mm:ss.fffffff zzz K 'at' dddd"));
Console.WriteLine(AprFools.ToString("yyyy-MM-dd HH:mm:ss.fffffff zzz K 'at' dddd 'the' 'first' 'of' 'April'"));
Console.WriteLine(AprFools.ToString("yyyy-MM-dd HH:mm:ss.fffffff zzz K 'at' dddd 'the' 'first' 'of' 'April' 'in' 'the' 'year' yyyy"));
Console.WriteLine(AprFools.ToString("yyyy-MM-dd HH:mm:ss.fffffff zzz K 'at' dddd 'the' 'first' 'of' 'April' 'in' 'the' 'year' yyyy 'and' 'the' 'time' hh:mm tt"));

Console.WriteLine($"{AprFools:dddd, MMMM, d yyyy}");
Console.WriteLine($"{AprFools:yyy MM ddd h:mm:ss tt}");
Console.WriteLine($"{AprFools:MMM dd yyyy}");

// Day formats.
Console.WriteLine($"d             (day of the month (1-2 digits).");
Console.WriteLine($"dd             (day of the month (2 digits)).");
Console.WriteLine($"ddd          (day of the week (abbreviated)).");
Console.WriteLine($"dddd                (day of the week (full)).");

// Fractional seconds.
Console.WriteLine($"f                        (10ths of a second).");
Console.WriteLine($"ff                      (100ths of a second).");
Console.WriteLine($"fff                    (1000ths of a second).");
Console.WriteLine($"ffff                  (10000ths of a second).");
Console.WriteLine($"fffff                (100000ths of a second).");
Console.WriteLine($"ffffff              (1000000ths of a second).");
Console.WriteLine($"fffffff            (10000000ths of a second).");

// Fractional seconds.
Console.WriteLine($"F             (10ths of a second (non-zero)).");
Console.WriteLine($"FF           (100ths of a second (non-zero)).");
Console.WriteLine($"FFF         (1000ths of a second (non-zero)).");
Console.WriteLine($"FFFF       (10000ths of a second (non-zero)).");
Console.WriteLine($"FFFFF     (100000ths of a second (non-zero)).");
Console.WriteLine($"FFFFFF   (1000000ths of a second (non-zero)).");
Console.WriteLine($"FFFFFFF (10000000ths of a second (non-zero)).");

// Era.
Console.WriteLine($"g                               (period/era):");

// Hour formats.
Console.WriteLine($"h               (12 hour clock (1-2 digits)).");
Console.WriteLine($"hh                (12 hour clock (2 digits)).");
Console.WriteLine($"H               (24 hour clock (1-2 digits)).");
Console.WriteLine($"HH                (24 hour clock (2 digits)).");

// Time zone.
Console.WriteLine($"K                                (time zone).");

// Minute formats.
Console.WriteLine($"m                      (minute (1-2 digits)).");
Console.WriteLine($"mm                       (minute (2 digits)).");

// Month formats.
Console.WriteLine($"M                       (month (1-2 digits)).");
Console.WriteLine($"MM                        (month (2 digits)).");
Console.WriteLine($"MMM                    (month (abbreviated)).");
Console.WriteLine($"MMMM                          (month (full)).");

// Second formats.
Console.WriteLine($"s                      (second (1-2 digits)).");
Console.WriteLine($"ss                       (second (2 digits)).");

// AM/PM.
Console.WriteLine($"t                      (AM/PM (abbreviated)).");
Console.WriteLine($"tt                            (AM/PM (full)).");

// Year formats.
Console.WriteLine($"y                        (year (1-2 digits)).");
Console.WriteLine($"yy                         (year (2 digits)).");
Console.WriteLine($"yyy                      (year (3-4 digits)).");
Console.WriteLine($"yyyy                       (year (4 digits)).");
Console.WriteLine($"yyyyy                      (year (5 digits)).");

// UTC offset.
Console.WriteLine($"z             (utc hour offset (1-2 digits)).");
Console.WriteLine($"zz              (utc hour offset (2 digits)).");
Console.WriteLine($"zzz             (utc hour and minute offset).");

// Composite formatting.
Console.WriteLine($"Custom: {AprFools:dddd, MMMM dd yyyy, hh:mm:ss tt K}");
