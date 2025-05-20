// C# code​​​​​​‌‌​‌​‌​‌‌‌​‌​​‌​​​​‌​‌​‌‌ below
using System.Text.RegularExpressions;

// This is how your code will be called.
// You can edit this code to try different testing cases.
string[] test_strs = {
    "12/25/2030",
    "1/1/2020",
    "Juneuary 6",
    "07/28/1980",
    "K8",
    "3/15/99",
};

// Try out the code by using each of the test_strs, or enter your own:
foreach (string str in test_strs)
{
    string result = Answer.ReverseDate(str);
    Console.WriteLine($"Input: {str}");
    Console.WriteLine($"Result: {result}");
    Console.WriteLine();
}

// Write your answer here, and then test your code.
public class Answer
{
    public static string ReverseDate(string date_str)
    {
        // Your code goes here.
        const int TIME_OUT = 1000;
        if (DateTime.TryParse(date_str, out DateTime date))
        {
            try
            {
                return Regex.Replace(date_str,
                @"^(?<mon>\d{1,2})/(?<day>\d{1,2})/(?<year>\d{2,4})$",
                "${year}-${mon}-${day}",
                RegexOptions.None,
                TimeSpan.FromMilliseconds(TIME_OUT));
            }
            catch (RegexMatchTimeoutException)
            {
                return date.ToString();
            }
        }

        return "";
    }
}
