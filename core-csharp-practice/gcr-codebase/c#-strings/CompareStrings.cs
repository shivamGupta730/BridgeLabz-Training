using System;

class CompareStrings
{
    static void Main()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();

        int i = 0;

        while (i < a.Length && i < b.Length)
        {
            if (a[i] < b[i])
            {
                Console.WriteLine("First string is smaller");
                return;
            }
            else if (a[i] > b[i])
            {
                Console.WriteLine("First string is greater");
                return;
            }
            i++;
        }

        if (a.Length == b.Length)
            Console.WriteLine("Both strings are equal");
        else if (a.Length < b.Length)
            Console.WriteLine("First string is smaller");
        else
            Console.WriteLine("First string is greater");
    }
}
