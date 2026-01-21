using System;
using System.Collections.Generic;

class NthElementFromEnd
{
    static void Main()
    {
        LinkedList<string> list = new LinkedList<string>();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            list.AddLast(Console.ReadLine());

        Console.Write("Enter N: ");
        int k = int.Parse(Console.ReadLine());

        var fast = list.First;
        var slow = list.First;

        for (int i = 0; i < k; i++)
            fast = fast.Next;

        while (fast != null)
        {
            slow = slow.Next;
            fast = fast.Next;
        }

        Console.WriteLine("Nth element from end: " + slow.Value);
    }
}
