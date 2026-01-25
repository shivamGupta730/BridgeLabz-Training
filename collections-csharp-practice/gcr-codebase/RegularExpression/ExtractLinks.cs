using System;
using System.Text.RegularExpressions;

class ExtractLinks
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();

        string pattern = @"https?://[^\s]+";

        foreach (Match m in Regex.Matches(input, pattern))
            Console.WriteLine(m.Value);
    }
}
