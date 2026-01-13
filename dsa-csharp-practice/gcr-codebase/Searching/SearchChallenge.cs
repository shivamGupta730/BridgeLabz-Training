using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element " + (i + 1) + ": ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // -------- Linear Search Part --------
        int[] visited = new int[n + 1];

        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 0 && arr[i] <= n)
            {
                visited[arr[i]] = 1;
            }
        }

        int missing = -1;
        for (int i = 1; i <= n; i++)
        {
            if (visited[i] == 0)
            {
                missing = i;
                break;
            }
        }

        Console.WriteLine("First missing positive number: " + missing);

        // -------- Binary Search Part --------
        Console.Write("Enter target value: ");
        int target = Convert.ToInt32(Console.ReadLine());

        Array.Sort(arr);

        int low = 0;
        int high = n - 1;
        int index = -1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target)
            {
                index = mid;
                break;
            }
            else if (arr[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        if (index != -1)
        {
            Console.WriteLine("Target found at index (after sorting): " + index);
        }
        else
        {
            Console.WriteLine("Target not found");
        }
    }
}
