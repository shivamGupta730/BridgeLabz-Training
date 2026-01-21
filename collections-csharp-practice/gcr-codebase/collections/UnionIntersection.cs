using System;
using System.Collections.Generic;

class UnionIntersection
{
    static void Main()
    {
        HashSet<int> set1 = ReadSet();
        HashSet<int> set2 = ReadSet();

        HashSet<int> union = new HashSet<int>(set1);
        union.UnionWith(set2);

        HashSet<int> intersection = new HashSet<int>(set1);
        intersection.IntersectWith(set2);

        Console.WriteLine("Union: " + string.Join(" ", union));
        Console.WriteLine("Intersection: " + string.Join(" ", intersection));
    }

    static HashSet<int> ReadSet()
    {
        HashSet<int> set = new HashSet<int>();
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
            set.Add(int.Parse(Console.ReadLine()));
        return set;
    }
}
