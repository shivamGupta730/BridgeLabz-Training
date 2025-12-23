using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level1
{
    internal class MeanHeight
    {
        static void Main(string[] args)
        {
            double[] h = new double[11];
            double sum = 0.0;

            for (int i = 0; i < h.Length; i++)
            {
                Console.Write("Enter height of player " + (i + 1) + ": ");
                h[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < h.Length; i++)
            {
                sum += h[i];
            }

            double mean = sum / h.Length;
            Console.WriteLine("\nMean height of the football team = " + mean);
        }
    }
}
