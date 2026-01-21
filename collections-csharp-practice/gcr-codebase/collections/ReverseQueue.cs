using System;
using System.Collections.Generic;

class ReverseQueue
{
    static void Main()
    {
        Queue<int> queue = new Queue<int>();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            queue.Enqueue(int.Parse(Console.ReadLine()));

        Stack<int> stack = new Stack<int>();
        while (queue.Count > 0)
            stack.Push(queue.Dequeue());

        while (stack.Count > 0)
            queue.Enqueue(stack.Pop());

        Console.WriteLine("Reversed Queue:");
        foreach (int x in queue)
            Console.Write(x + " ");
    }
}
