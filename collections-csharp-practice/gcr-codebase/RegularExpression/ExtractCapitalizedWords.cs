using System;
using System.Text.RegularExpressions;

class ExtractCapitalizedWords
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        // Pattern to match capitalized words
        string pattern = @"\b[A-Z][a-z]*\b";

        MatchCollection matches = Regex.Matches(input, pattern);

        if (matches.Count == 0)
        {
            Console.WriteLine("No capitalized words found");
        }
        else
        {
            Console.WriteLine("Capitalized words:");
            foreach (Match m in matches)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
    