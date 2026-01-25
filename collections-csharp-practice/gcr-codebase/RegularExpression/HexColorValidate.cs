using System;
using System.Text.RegularExpressions;

    class HexColorValidate
    {
        static void Main()
        {
            Console.WriteLine("Enter Hex Color Code:");
            string input = Console.ReadLine();

            string pattern = @"^#[0-9A-Fa-f]{6}$";

            if (Regex.IsMatch(input, pattern))
            {
                Console.WriteLine("Valid Hex Color Code");
            }
            else
            {
                Console.WriteLine("Invalid Hex Color Code");
            }
        }
    }

