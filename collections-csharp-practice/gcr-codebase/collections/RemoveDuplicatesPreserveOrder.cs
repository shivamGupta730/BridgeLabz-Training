using System;
using System.Collections.Generic;

class RemoveDuplicatesPreserveOrder
{
    static void Main()
    {
        List<int> list = new List<int>();
        HashSet<int> seen = new HashSet<int>();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            list.Add(int.Parse(Console.ReadLine()));

        Console.WriteLine("After removing duplicates:");
        foreach (int x in list)
        {
            if (seen.Add(x))
                Console.Write(x + " ");
        }
    }
}
