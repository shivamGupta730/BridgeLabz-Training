using System;
using System.Text.RegularExpressions;

    public class UserName
    {
        public static void Main(string[] args)
        {
             string pattern=@"^[a-zA-Z]\w{4,14}$";
             System.Console.WriteLine("enter the text");
        string input= Console.ReadLine() ;
        Match match=Regex.Match(input,pattern);
            if (match.Success)
            {
                System.Console.WriteLine("Validate");
            }
        }
    }
