using System;

class CountingSortAges
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] ages = new int[n];

        Console.WriteLine("Enter ages (10 to 18):");
        for (int i = 0; i < n; i++)
            ages[i] = int.Parse(Console.ReadLine());

        int min = 10, max = 18;
        int[] count = new int[max - min + 1];

        for (int i = 0; i < n; i++)
            count[ages[i] - min]++;

        int index = 0;
        for (int i = 0; i < count.Length; i++)
        {
            while (count[i]-- > 0)
                ages[index++] = i + min;
        }

        Console.WriteLine("Sorted Ages:");
        foreach (int a in ages)
            Console.Write(a + " ");
    }
}
