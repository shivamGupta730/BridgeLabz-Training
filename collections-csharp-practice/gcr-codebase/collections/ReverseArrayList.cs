using System;
using System.Collections;

class ReverseArrayList
{
    static void Main()
    {
        ArrayList list = new ArrayList();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            list.Add(Console.ReadLine());

        int start = 0, end = list.Count - 1;
        while (start < end)
        {
            object temp = list[start];
            list[start] = list[end];
            list[end] = temp;
            start++;
            end--;
        }

        Console.WriteLine("Reversed List:");
        foreach (var item in list)
            Console.Write(item + " ");
    }
}
