using System;

namespace BridgeLabzTraining.arrays.level2
{
    internal class LargestSecondNumberResize
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int maxD = 10;
            int[] d = new int[maxD];
            int idx = 0;

            while (n != 0)
            {
                if (idx == maxD)
                {
                    maxD += 10;
                    int[] t = new int[maxD];
                    for (int i = 0; i < d.Length; i++)
                        t[i] = d[i];
                    d = t;
                }

                d[idx] = n % 10;
                n /= 10;
                idx++;
            }

            int l = 0;
            int sl = 0;

            for (int i = 0; i < idx; i++)
            {
                if (d[i] > l)
                {
                    sl = l;
                    l = d[i];
                }
                else if (d[i] > sl && d[i] != l)
                {
                    sl = d[i];
                }
            }

            Console.WriteLine(l);
            Console.WriteLine(sl);
        }
    }
}
