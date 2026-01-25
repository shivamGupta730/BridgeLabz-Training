using System;
using System.Text.RegularExpressions;

class ExtractDates
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();

        string pattern = @"\b\d{2}/\d{2}/\d{4}\b";

        foreach (Match m in Regex.Matches(input, pattern))
            Console.WriteLine(m.Value);
    }
}
