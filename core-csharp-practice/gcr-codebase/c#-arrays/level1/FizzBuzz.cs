using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgeLabzTraining.arrays.level1
{
    internal class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive number: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Negative Number.");
                return;
            }

            string[] res = new string[n + 1];

            for (int i = 0; i <= n; i++)
            {
                if (i == 0) res[i] = "0";
                else if (i % 3 == 0 && i % 5 == 0) res[i] = "FizzBuzz";
                else if (i % 3 == 0) res[i] = "Fizz";
                else if (i % 5 == 0) res[i] = "Buzz";
                else res[i] = i.ToString();
            }

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Position " + i + " = " + res[i]);
            }
        }
    }
}

