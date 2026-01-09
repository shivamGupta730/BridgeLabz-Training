using System;
using System.Collections.Generic;

class TwoSum
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

        for (int i = 0; i < n; i++)
        {
            int need = target - arr[i];

            if (map.ContainsKey(need))
            {
                Console.WriteLine("Indices: " + map[need] + " and " + i);
                return;
            }

            if (!map.ContainsKey(arr[i]))
                map[arr[i]] = i;
        }

        Console.WriteLine("No pair found");
    }
}
