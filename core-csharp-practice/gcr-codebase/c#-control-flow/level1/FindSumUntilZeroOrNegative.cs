using System;

class FindSumUntilZeroOrNegative
{
    static void Main()
    {
        double t = 0.0;

        while (true)
        {
            double num = double.Parse(Console.ReadLine());

            if (num <= 0)
            {
                break;
            }

            t = t + num;
        }

        Console.WriteLine(t);
    }
}
