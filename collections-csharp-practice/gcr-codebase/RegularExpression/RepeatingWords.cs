using System;
using System.Text.RegularExpressions;

class RepeatingWords
{
    static void Main()
    {
        Console.WriteLine("Enter sentence:");
        string input = Console.ReadLine();

        string pattern = @"\b(\w+)\s+\1\b";

        foreach (Match m in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
            Console.WriteLine(m.Groups[1].Value);
    }
}
