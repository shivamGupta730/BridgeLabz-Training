using System;

class SimpleInterestCalculation
{
    static void Main()
    {
        double p, r, t;
        p = Convert.ToDouble(Console.ReadLine());
        r = Convert.ToDouble(Console.ReadLine());
        t = Convert.ToDouble(Console.ReadLine());

        double intrst = (p * r * t) / 100;

        Console.WriteLine("The Simple Interest is " + intrst +
                          " for Principal " + p+
                          ", Rate of Interest " + r+
                          " and Time " + t);
    }
}
