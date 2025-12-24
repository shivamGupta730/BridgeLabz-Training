using System;

namespace BridgeLabzTraining.arrays.level2
{
    internal class ReverseNumber
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int t = n;
            int c = 0;

            while (t > 0)
            {
                c++;
                t /= 10;
            }

            int[] d = new int[c];
            int[] r = new int[c];

            t = n;
            for (int i = 0; i < c; i++)
            {
                d[i] = t % 10;
                t /= 10;
            }

            for (int i = 0; i < c; i++)
            {
                r[i] = d[c - 1 - i];
            }

            for (int i = 0; i < c; i++)
            {
                Console.Write(r[i]);
            }
        }
    }
}
