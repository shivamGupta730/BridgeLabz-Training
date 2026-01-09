using System;
using System.Collections.Generic;

class StockSpan
{
    public static void CalculateSpan(int[] price, int n)
    {
        int[] span = new int[n];
        Stack<int> stack = new Stack<int>();

        // First day ka span hamesha 1 hota hai
        span[0] = 1;
        stack.Push(0);

        for (int i = 1; i < n; i++)
        {
            // Chhote ya barabar price wale pop karo
            while (stack.Count > 0 && price[stack.Peek()] <= price[i])
            {
                stack.Pop();
            }

            if (stack.Count == 0)
                span[i] = i + 1;
            else
                span[i] = i - stack.Peek();

            stack.Push(i);
        }

        // Output
        Console.WriteLine("Stock Spans:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(span[i] + " ");
        }
    }

    static void Main()
    {
        Console.Write("Enter number of days: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] price = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter price for day " + (i + 1) + ": ");
            price[i] = Convert.ToInt32(Console.ReadLine());
        }

        CalculateSpan(price, n);
    }
}
