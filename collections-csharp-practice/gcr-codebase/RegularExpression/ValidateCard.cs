using System;
using System.Text.RegularExpressions;

class ValidateCard
{
    static void Main()
    {
        Console.WriteLine("Enter card number:");
        string input = Console.ReadLine();

        string visa = @"^4\d{15}$";
        string master = @"^5\d{15}$";

        if (Regex.IsMatch(input, visa))
            Console.WriteLine("Valid Visa");
        else if (Regex.IsMatch(input, master))
            Console.WriteLine("Valid MasterCard");
        else
            Console.WriteLine("Invalid Card");
    }
}
