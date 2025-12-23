using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabzTraining.arrays.level1
{ internal class Factors
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            int max = 10;
            int[] fac = new int[max];
            int idx = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    if (idx == max)
                    {
                        max = max * 2;
                        int[] tmp = new int[max];

                        for (int j = 0; j < idx; j++)
                        {
                            tmp[j] = fac[j];
                        }

                        fac = tmp;
                    }

                    fac[idx] = i;
                    idx++;
                }
            }

            Console.WriteLine("Factors of " + n + ":");
            for (int i = 0; i < idx; i++)
            {
                Console.Write(fac[i] + " ");
            }
        }
    }
}
