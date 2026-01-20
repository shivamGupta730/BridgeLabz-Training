using System;

namespace AadhaarSorting
{
    class RadixSortAadhaar
    {
        static void CountingSort(long[] arr, int exp)
        {
            int n = arr.Length;
            long[] output = new long[n];
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;

            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];

            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (int)((arr[i] / exp) % 10);
                output[count[digit] - 1] = arr[i];
                count[digit]--;
            }

            for (int i = 0; i < n; i++)
                arr[i] = output[i];
        }

        static void RadixSort(long[] arr)
        {
            long max = arr[0];
            foreach (long x in arr)
                if (x > max) max = x;

            for (int exp = 1; max / exp > 0; exp *= 10)
                CountingSort(arr, exp);
        }

        static int BinarySearch(long[] arr, long key)
        {
            int l = 0, r = arr.Length - 1;

            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (arr[mid] == key) return mid;
                if (arr[mid] < key) l = mid + 1;
                else r = mid - 1;
            }
            return -1;
        }

        static void Main()
        {
            Console.Write("Enter number of Aadhaar entries: ");
            int n = int.Parse(Console.ReadLine());

            long[] arr = new long[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter Aadhaar {i + 1}: ");
                arr[i] = long.Parse(Console.ReadLine());
            }

            RadixSort(arr);

            Console.WriteLine("Sorted Aadhaar Numbers:");
            foreach (long x in arr)
                Console.WriteLine(x);

            Console.Write("Enter Aadhaar to search: ");
            long key = long.Parse(Console.ReadLine());

            int index = BinarySearch(arr, key);
            Console.WriteLine(index == -1 ? "Not Found" : "Found at index " + index);
        }
    }
}
