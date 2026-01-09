using System;
using System.Collections.Generic;

class QueueUsingStacks
{
    Stack<int> s1 = new Stack<int>(); // enqueue stack
    Stack<int> s2 = new Stack<int>(); // dequeue stack

    // Enqueue operation
    public void Enqueue(int data)
    {
        s1.Push(data);
        Console.WriteLine(data + " inserted in queue");
    }

    // Dequeue operation
    public void Dequeue()
    {
        if (s1.Count == 0 && s2.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        if (s2.Count == 0)
        {
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }
        }

        Console.WriteLine("Deleted element: " + s2.Pop());
    }

    // Display Queue
    public void Display()
    {
        if (s1.Count == 0 && s2.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Console.Write("Queue elements: ");

        foreach (int item in s2)
            Console.Write(item + " ");

        Stack<int> temp = new Stack<int>(s1);
        foreach (int item in temp)
            Console.Write(item + " ");

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        QueueUsingStacks q = new QueueUsingStacks();
        int choice, value;

        do
        {
            Console.WriteLine("\n1. Enqueue");
            Console.WriteLine("2. Dequeue");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter value: ");
                    value = Convert.ToInt32(Console.ReadLine());
                    q.Enqueue(value);
                    break;

                case 2:
                    q.Dequeue();
                    break;

                case 3:
                    q.Display();
                    break;

                case 4:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        while (choice != 4);
    }
}
