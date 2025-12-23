using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace BridgeLabzTraining.arrays.level1
{
    internal class OddEvenArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Invalid number");
                return;
            }

            int[] odd = new int[n];
            int[] even = new int[n];

            int o = 0, e = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    even[e] = i;
                    e++;
                }
                else
                {
                    odd[o] = i;
                    o++;
                }
            }

            Console.WriteLine("Odd numbers:");
            for (int i = 0; i < o; i++)
            {
                Console.Write(odd[i] + " ");
            }

            Console.WriteLine("\nEven numbers:");
            for (int i = 0; i < e; i++)
            {
                Console.Write(even[i] + " ");
            }
        }
    }
}


