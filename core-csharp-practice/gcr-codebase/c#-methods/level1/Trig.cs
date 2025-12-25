using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class Trig
    {
        public static double[] Cal(double d)
        {
            double r = d * Math.PI / 180;

            double s = Math.Sin(r);
            double c = Math.Cos(r);
            double t = Math.Tan(r);

            return new double[] { s, c, t };
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter angle in degrees:");
            double d = double.Parse(Console.ReadLine());

            double[] res = Trig.Cal(d);

            Console.WriteLine("Sin = " + res[0]);
            Console.WriteLine("Cos = " + res[1]);
            Console.WriteLine("Tan = " + res[2]);
        }
    }
}
