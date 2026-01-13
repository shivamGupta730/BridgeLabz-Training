using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        StringBuilder sb = new StringBuilder(input);
        StringBuilder reverse = new StringBuilder();

        for (int i = sb.Length - 1; i >= 0; i--)
        {
            reverse.Append(sb[i]);
        }

        Console.WriteLine("Reversed string: " + reverse.ToString());
    }
}
