using System;
using System.Text.RegularExpressions;

class ReplaceSpaces
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();

        string result = Regex.Replace(input, @"\s+", " ");
        Console.WriteLine(result);
    }
}
