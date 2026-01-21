using System;
using System.Collections.Generic;

class ReverseLinkedList
{
    static void Main()
    {
        LinkedList<int> list = new LinkedList<int>();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            list.AddLast(int.Parse(Console.ReadLine()));

        LinkedList<int> reversed = new LinkedList<int>();
        foreach (int item in list)
            reversed.AddFirst(item);

        Console.WriteLine("Reversed LinkedList:");
        foreach (var item in reversed)
            Console.Write(item + " ");
    }
}
