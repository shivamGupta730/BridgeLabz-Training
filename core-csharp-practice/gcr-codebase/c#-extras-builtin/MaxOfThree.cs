using System;

class MaxOfThree
{
    static void Main()
    {
        int a = ReadNumber();
        int b = ReadNumber();
        int c = ReadNumber();

        int max = FindMax(a, b, c);

        Console.WriteLine(max);
    }

    static int ReadNumber()
    {
        return int.Parse(Console.ReadLine());
    }

    static int FindMax(int x, int y, int z)
    {
        int max = x;

        if (y > max)
            max = y;

        if (z > max)
            max = z;

        return max;
    }
}
