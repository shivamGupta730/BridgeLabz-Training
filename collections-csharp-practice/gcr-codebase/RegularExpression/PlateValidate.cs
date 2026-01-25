using System;
using System.Text.RegularExpressions;


    public class PlateValidate
    {
        public static void Main(string[] args)
        {
            string pattern=@"^[A-Z]{2}\d{4}$";
            string input=Console.ReadLine();
            Match match=Regex.Match(input,pattern);
            if (match.Success)
            {
                System.Console.WriteLine("Valid");
            }
            else
            {
                System.Console.WriteLine("Invalid");
            }
        }
        
    }
