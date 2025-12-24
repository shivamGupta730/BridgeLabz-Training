using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level2
{
    internal class StudentGradeMarks
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] m = new int[n, 3];
            double[] p = new double[n];
            char[] g = new char[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (m[i, j] < 0)
                        j--;
                }
            }

            for (int i = 0; i < n; i++)
            {
                int t = m[i, 0] + m[i, 1] + m[i, 2];
                p[i] = t / 3.0;

                if (p[i] >= 80) g[i] = 'A';
                else if (p[i] >= 70) g[i] = 'B';
                else if (p[i] >= 60) g[i] = 'C';
                else if (p[i] >= 50) g[i] = 'D';
                else if (p[i] >= 40) g[i] = 'E';
                else g[i] = 'R';
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(m[i, 0] + "," + m[i, 1] + "," + m[i, 2] + "," + p[i] + "," + g[i]);
            }
        }
    }
}
