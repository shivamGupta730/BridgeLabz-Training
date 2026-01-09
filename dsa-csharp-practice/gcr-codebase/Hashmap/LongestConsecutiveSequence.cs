using System;
using System.Collections.Generic;

class LongestConsecutiveSequence
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

        HashSet<int> set = new HashSet<int>();
        foreach (int num in arr)
            set.Add(num);

        int longest = 0;

        foreach (int num in arr)
        {
            // start of sequence
            if (!set.Contains(num - 1))
            {
                int current = num;
                int count = 1;

                while (set.Contains(current + 1))
                {
                    current++;
                    count++;
                }

                longest = Math.Max(longest, count);
            }
        }

        Console.WriteLine("Longest consecutive sequence length: " + longest);
    }
}
