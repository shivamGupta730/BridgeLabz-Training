using System;
using System.Text.RegularExpressions;

class ValidateSSN
{
    static void Main()
    {
        Console.WriteLine("Enter SSN:");
        string input = Console.ReadLine();

        string pattern = @"^\d{3}-\d{2}-\d{4}$";

        Console.WriteLine(Regex.IsMatch(input, pattern) ? "Valid SSN" : "Invalid SSN");
    }
}
