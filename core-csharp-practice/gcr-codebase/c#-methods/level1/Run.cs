using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class Run
    {
        public double Cal(double a, double b, double c)
        {
            double p = a + b + c;
            return 5000 / p;
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three sides of triangle:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Run r = new Run();
            double res = r.Cal(a, b, c);

            Console.WriteLine("Rounds needed = " + res);
        }
    }
}
