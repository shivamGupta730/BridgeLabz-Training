using System;

class NaturalSumCheck
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            int sum1 = 0;
            int i = 1;

            while (i <= n)
            {
                sum1 = sum1 + i;
                i++;
            }

            int sum2 = n * (n + 1) / 2;

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);

            if (sum1 == sum2)
            {
                Console.WriteLine("Result is correct");
            }
            else
            {
                Console.WriteLine("Result is not correct");
            }
        }
        else
        {
            Console.WriteLine("Not a natural number");
        }
    }
}
