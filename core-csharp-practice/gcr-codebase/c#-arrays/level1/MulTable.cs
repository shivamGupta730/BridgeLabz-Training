using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level1
{
    internal class MulTable
    {
        static void Main(string[] args)
        {
            int num;

            // Result store karne ke liye array
            int[] res = new int[4];

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 6; i <= 9; i++)
            {
                res[i - 6] = num * i;
            }

            Console.WriteLine();

            // Result print kar rahe hain
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + res[i - 6]);
            }
        }
    }
}

