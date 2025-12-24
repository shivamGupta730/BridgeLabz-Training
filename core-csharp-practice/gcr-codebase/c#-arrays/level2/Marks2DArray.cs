using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level2
{
    internal class Marks2DArray
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] m = new int[n, 3];
            double[] per = new double[n];
            char[] g = new char[n];

            for (int i = 0; i < n; i++)
            {
                m[i, 0] = Convert.ToInt32(Console.ReadLine()); // physics
                m[i, 1] = Convert.ToInt32(Console.ReadLine()); // chemistry
                m[i, 2] = Convert.ToInt32(Console.ReadLine()); // maths
            }

            for (int i = 0; i < n; i++)
            {
                int tot = m[i, 0] + m[i, 1] + m[i, 2];
                per[i] = tot / 3.0;

                if (per[i] >= 75)
                    g[i] = 'A';
                else if (per[i] >= 60)
                    g[i] = 'B';
                else if (per[i] >= 40)
                    g[i] = 'C';
                else
                    g[i] = 'F';
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(per[i] + " " + g[i]);
            }
        }
    }
}
