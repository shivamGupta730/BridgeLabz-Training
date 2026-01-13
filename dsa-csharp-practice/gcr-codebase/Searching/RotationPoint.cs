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

        int low = 0;
        int high = n - 1;

        while (low < high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] > arr[high])
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }

        Console.WriteLine("Smallest element: " + arr[low]);
        Console.WriteLine("Rotation point index: " + low);
    }
}
