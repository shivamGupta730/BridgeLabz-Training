using System;
using System.Collections.Generic;

class SlidingWindowMaximum
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter window size k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        LinkedList<int> dq = new LinkedList<int>();

        for (int i = 0; i < n; i++)
        {
            // Remove elements out of window
            if (dq.Count > 0 && dq.First.Value <= i - k)
                dq.RemoveFirst();

            // Remove smaller elements
            while (dq.Count > 0 && arr[dq.Last.Value] <= arr[i])
                dq.RemoveLast();

            dq.AddLast(i);

            // Print max of window
            if (i >= k - 1)
                Console.Write(arr[dq.First.Value] + " ");
        }
    }
}
