using System;
using System.Collections.Generic;

class ZeroSumSubarrays
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

        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        int sum = 0;

        // sum 0 at index -1
        map[0] = new List<int> { -1 };

        for (int i = 0; i < n; i++)
        {
            sum += arr[i];

            if (map.ContainsKey(sum))
            {
                foreach (int startIndex in map[sum])
                {
                    Console.WriteLine("Zero sum subarray found from index "
                        + (startIndex + 1) + " to " + i);
                }
            }

            if (!map.ContainsKey(sum))
                map[sum] = new List<int>();

            map[sum].Add(i);
        }
    }
}
