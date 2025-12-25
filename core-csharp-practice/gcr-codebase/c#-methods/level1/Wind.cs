using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class Wind
    {
        public static double Cal(double t, double w)
        {
            double wc = 35.74 
                        + 0.6215 * t 
                        + (0.4275 * t - 35.75) * Math.Pow(w, 0.16);
            return wc;
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature:");
            double t = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter wind speed:");
            double w = double.Parse(Console.ReadLine());

            double res = Wind.Cal(t, w);

            Console.WriteLine("Wind Chill Temperature = " + res);
        }
    }
}
