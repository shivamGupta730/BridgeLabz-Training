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

        int index = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            Console.WriteLine("First negative number is: " + arr[index]);
            Console.WriteLine("Found at index: " + index);
        }
        else
        {
            Console.WriteLine("No negative number found");
        }
    }
}
