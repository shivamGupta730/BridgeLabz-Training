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

        Console.Write("Enter target element: ");
        int target = Convert.ToInt32(Console.ReadLine());

        int first = -1;
        int last = -1;

        // find first occurrence
        int low = 0;
        int high = n - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target)
            {
                first = mid;
                high = mid - 1;
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

        // find last occurrence
        low = 0;
        high = n - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target)
            {
                last = mid;
                low = mid + 1;
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

        if (first != -1)
        {
            Console.WriteLine("First occurrence index: " + first);
            Console.WriteLine("Last occurrence index: " + last);
        }
        else
        {
            Console.WriteLine("Element not found");
        }
    }
}
