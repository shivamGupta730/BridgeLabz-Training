using System;
using System.Text;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of times to add string: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Using normal string
        Stopwatch sw1 = new Stopwatch();
        sw1.Start();

        string normalString = "";
        for (int i = 0; i < n; i++)
        {
            normalString = normalString + "a";
        }

        sw1.Stop();

        // Using StringBuilder
        Stopwatch sw2 = new Stopwatch();
        sw2.Start();

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            sb.Append("a");
        }

        sw2.Stop();

        Console.WriteLine("Time using string: " + sw1.ElapsedMilliseconds + " ms");
        Console.WriteLine("Time using StringBuilder: " + sw2.ElapsedMilliseconds + " ms");
    }
}
