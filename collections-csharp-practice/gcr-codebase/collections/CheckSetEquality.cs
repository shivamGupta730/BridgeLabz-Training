using System;
using System.Collections.Generic;

class CheckSetEquality
{
    static void Main()
    {
        HashSet<int> set1 = ReadSet();
        HashSet<int> set2 = ReadSet();

        Console.WriteLine(set1.SetEquals(set2));
    }

    static HashSet<int> ReadSet()
    {
        HashSet<int> set = new HashSet<int>();
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            set.Add(int.Parse(Console.ReadLine()));

        return set;
    }
}
