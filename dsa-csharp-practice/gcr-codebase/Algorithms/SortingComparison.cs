using System;

class SortingComparison
{
    static void Main()
    {
        int[] sizes = { 1000, 10000 };

        foreach (int size in sizes)
        {
            Console.WriteLine("\nDataset Size: " + size);

            int[] originalArray = GenerateArray(size);

            // -------- Bubble Sort --------
            int[] bubbleArr = (int[])originalArray.Clone();

            DateTime startBubble = DateTime.Now;
            BubbleSort(bubbleArr);
            DateTime endBubble = DateTime.Now;

            double bubbleTime =
                (endBubble - startBubble).TotalMilliseconds;

            // Output Time (Approx):
            // N = 1,000  -> ~50 ms
            // N = 10,000 -> ~5000 ms (5 seconds)
            // N = 1,000,000 -> Unfeasible (>1 hour)

            // -------- Merge Sort --------
            int[] mergeArr = (int[])originalArray.Clone();

            DateTime startMerge = DateTime.Now;
            MergeSort(mergeArr, 0, mergeArr.Length - 1);
            DateTime endMerge = DateTime.Now;

            double mergeTime =
                (endMerge - startMerge).TotalMilliseconds;

            // Output Time (Approx):
            // N = 1,000  -> ~5 ms
            // N = 10,000 -> ~50 ms
            // N = 1,000,000 -> ~3000 ms (3 seconds)

            // -------- Quick Sort --------
            int[] quickArr = (int[])originalArray.Clone();

            DateTime startQuick = DateTime.Now;
            QuickSort(quickArr, 0, quickArr.Length - 1);
            DateTime endQuick = DateTime.Now;

            double quickTime =
                (endQuick - startQuick).TotalMilliseconds;

            // Output Time (Approx):
            // N = 1,000  -> ~3 ms
            // N = 10,000 -> ~30 ms
            // N = 1,000,000 -> ~2000 ms (2 seconds)

            Console.WriteLine("Bubble Sort Time (ms): " + bubbleTime);
            Console.WriteLine("Merge Sort Time (ms): " + mergeTime);
            Console.WriteLine("Quick Sort Time (ms): " + quickTime);
        }
    }

    // -------- Utility: Generate Array --------
    static int[] GenerateArray(int size)
    {
        int[] arr = new int[size];
        Random rand = new Random();

        for (int i = 0; i < size; i++)
        {
            arr[i] = rand.Next(1, size);
        }
        return arr;
    }

    // -------- Bubble Sort --------
    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // -------- Merge Sort --------
    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);

            Merge(arr, left, mid, right);
        }
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];

        for (int i = 0; i < n1; i++)
            L[i] = arr[left + i];
        for (int j = 0; j < n2; j++)
            R[j] = arr[mid + 1 + j];

        int iIndex = 0, jIndex = 0, k = left;

        while (iIndex < n1 && jIndex < n2)
        {
            if (L[iIndex] <= R[jIndex])
                arr[k++] = L[iIndex++];
            else
                arr[k++] = R[jIndex++];
        }

        while (iIndex < n1)
            arr[k++] = L[iIndex++];

        while (jIndex < n2)
            arr[k++] = R[jIndex++];
    }

    // -------- Quick Sort --------
    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);

            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int swap = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = swap;

        return i + 1;
    }
}
