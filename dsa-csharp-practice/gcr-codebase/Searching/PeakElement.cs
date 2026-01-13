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

        while (low <= high)
        {
            int mid = (low + high) / 2;

            bool leftOk = (mid == 0) || (arr[mid] >= arr[mid - 1]);
            bool rightOk = (mid == n - 1) || (arr[mid] >= arr[mid + 1]);

            if (leftOk && rightOk)
            {
                Console.WriteLine("Peak element: " + arr[mid]);
                Console.WriteLine("Peak index: " + mid);
                break;
            }
            else if (mid > 0 && arr[mid - 1] > arr[mid])
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
    }
}
