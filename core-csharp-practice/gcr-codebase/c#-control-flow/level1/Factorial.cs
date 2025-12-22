using System;

class Factorial
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        if (num > 0)
        {
            int fact = 1;
            int i = 1;

            while (i <= num)
            {
                fact = fact * i;
                i++;
            }

            Console.WriteLine(fact);
        }
        else
        {
            Console.WriteLine("Not a positive integer");
        }
    }
}
