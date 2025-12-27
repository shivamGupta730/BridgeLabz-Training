using System;

class PrimeCheck
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        if (IsPrime(num))
            Console.WriteLine("Prime Number");
        else
            Console.WriteLine("Not Prime Number");
    }

    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
}
