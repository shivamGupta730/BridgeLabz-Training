using System;
using System.Text.RegularExpressions;

class ValidateIP
{
    static void Main()
    {
        Console.WriteLine("Enter IP address:");
        string input = Console.ReadLine();

        string pattern = @"^((25[0-5]|2[0-4]\d|[01]?\d\d?)\.){3}(25[0-5]|2[0-4]\d|[01]?\d\d?)$";

        Console.WriteLine(Regex.IsMatch(input, pattern) ? "Valid IP" : "Invalid IP");
    }
}
