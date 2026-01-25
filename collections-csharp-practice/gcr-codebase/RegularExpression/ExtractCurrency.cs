using System;
using System.Text.RegularExpressions;

class ExtractLanguages
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();

        string pattern = @"\b(Java|Python|JavaScript|Go)\b";

        foreach (Match m in Regex.Matches(input, pattern))
            Console.WriteLine(m.Value);
    }
}
