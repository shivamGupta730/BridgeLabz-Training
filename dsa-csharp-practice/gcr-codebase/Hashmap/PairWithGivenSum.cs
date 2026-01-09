using System;
using System.Collections.Generic;

class PairWithGivenSum
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

        Console.Write("Enter target sum: ");
        int target = Convert.ToInt32(Console.ReadLine());

        Dictionary<int, int> map = new Dictionary<int, int>();
        bool found = false;

        for (int i = 0; i < n; i++)
        {
            int needed = target - arr[i];

            if (map.ContainsKey(needed))
            {
                Console.WriteLine("Pair found: " + needed + " + " + arr[i] + " = " + target);
                found = true;
                break;
            }

            if (!map.ContainsKey(arr[i]))
                map[arr[i]] = 1;
        }

        if (!found)
            Console.WriteLine("No pair found");
    }
}
