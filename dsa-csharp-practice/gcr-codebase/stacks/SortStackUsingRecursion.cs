using System;
using System.Collections.Generic;

class SortStackUsingRecursion
{
    Stack<int> stack = new Stack<int>();

    // Push element
    public void Push(int data)
    {
        stack.Push(data);
        Console.WriteLine(data + " pushed");
    }

    // Sort stack using recursion
    public void SortStack()
    {
        if (stack.Count == 0)
            return;

        int temp = stack.Pop();
        SortStack();
        InsertSorted(temp);
    }

    // Insert element in sorted order
    private void InsertSorted(int data)
    {
        if (stack.Count == 0 || stack.Peek() <= data)
        {
            stack.Push(data);
            return;
        }

        int temp = stack.Pop();
        InsertSorted(data);
        stack.Push(temp);
    }

    // Display stack
    public void Display()
    {
        if (stack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
            return;
        }

        Console.WriteLine("Stack elements:");
        foreach (int item in stack)
            Console.WriteLine(item);
    }
}

class Program
{
    static void Main()
    {
        SortStackUsingRecursion s = new SortStackUsingRecursion();
        int choice, value;

        do
        {
            Console.WriteLine("\n1. Push");
            Console.WriteLine("2. Sort Stack");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter value: ");
                    value = Convert.ToInt32(Console.ReadLine());
                    s.Push(value);
                    break;

                case 2:
                    s.SortStack();
                    Console.WriteLine("Stack sorted");
                    break;

                case 3:
                    s.Display();
                    break;

                case 4:
                    Console.WriteLine("Exit");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        while (choice != 4);
    }
}
