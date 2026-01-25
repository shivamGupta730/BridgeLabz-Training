using System;
using System.Text.RegularExpressions;

class CensorWords
{
    static void Main()
    {
        Console.WriteLine("Enter sentence:");
        string input = Console.ReadLine();

        string pattern = @"\b(damn|stupid)\b";
        string result = Regex.Replace(input, pattern, "****", RegexOptions.IgnoreCase);

        Console.WriteLine(result);
    }
}
