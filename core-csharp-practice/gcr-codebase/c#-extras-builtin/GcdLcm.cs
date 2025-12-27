using System;

class GcdLcm
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int gcd = FindGcd(a, b);
        int lcm = FindLcm(a, b);

        Console.WriteLine("GCD = " + gcd);
        Console.WriteLine("LCM = " + lcm);
    }

    static int FindGcd(int x, int y)
    {
        while (y != 0)
        {
            int temp = y;
            y = x % y;
            x = temp;
        }
        return x;
    }

    static int FindLcm(int x, int y)
    {
        return (x * y) / FindGcd(x, y);
    }
}
