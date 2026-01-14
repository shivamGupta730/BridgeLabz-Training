using System;

class SearchComparison
{
    static void Main()
    {
        int[] sizes = { 1000, 10000, 1000000 };

        foreach (int size in sizes)
        {
            Console.WriteLine("\nDataset Size: " + size);

            int[] arr = new int[size];

            // Fill array with sorted values
            for (int i = 0; i < size; i++)
            {
                arr[i] = i + 1;
            }

            int target = size; // worst case (last element)

            // ---------------- Linear Search ----------------
            DateTime startLinear = DateTime.Now;
            LinearSearch(arr, target);
            DateTime endLinear = DateTime.Now;

            double linearTime =
                (endLinear - startLinear).TotalMilliseconds;

            // Output Time (Approx):
            // N = 1,000     -> ~1 ms
            // N = 10,000    -> ~10 ms
            // N = 1,000,000 -> ~1000 ms (1 second)

            // ---------------- Binary Search ----------------
            DateTime startBinary = DateTime.Now;
            BinarySearch(arr, target);
            DateTime endBinary = DateTime.Now;

            double binaryTime =
                (endBinary - startBinary).TotalMilliseconds;

            // Output Time (Approx):
            // N = 1,000     -> ~0.01 ms
            // N = 10,000    -> ~0.02 ms
            // N = 1,000,000 -> ~0.1 ms

            Console.WriteLine("Linear Search Time (ms): " + linearTime);
            Console.WriteLine("Binary Search Time (ms): " + binaryTime);
        }
    }

    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i;
        }
        return -1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return -1;
    }
}
