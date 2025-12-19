using System;

class DistInYardsAndMiles
{
    static void Main()
    {
        double f;
        f = Convert.ToDouble(Console.ReadLine());

        double y = f / 3;
        double m = y / 1760;

        Console.WriteLine("The distance in yards is " + y+ " and in miles is " + m);
    }
}
