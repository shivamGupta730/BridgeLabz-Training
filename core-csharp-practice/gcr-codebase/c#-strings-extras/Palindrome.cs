using System;

public class Palindrome
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter the string");
        string str = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(str))
        {
            Console.WriteLine("string is empty");
        }
        else
        {
            str = str.ToLower();  

            char[] arr = str.ToCharArray();
            char[] newChar = new char[arr.Length];

            int j = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                newChar[j] = arr[i];
                j++;
            }

            string old = string.Concat(arr);
            string result = string.Concat(newChar);

            if (old.Equals(result))
            {
                Console.WriteLine("string is Palindrome");
            }
            else
            {
                Console.WriteLine("string is not Palindrome");
            }
        }
    }
}
