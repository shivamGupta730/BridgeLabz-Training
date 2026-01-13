using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of strings: ");
        int n = Convert.ToInt32(Console.ReadLine());

        string[] arr = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter string " + (i + 1) + ": ");
            arr[i] = Console.ReadLine();
        }

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < arr.Length; i++)
        {
            sb.Append(arr[i]);
        }

        Console.WriteLine("Final string: " + sb.ToString());
    }
}
