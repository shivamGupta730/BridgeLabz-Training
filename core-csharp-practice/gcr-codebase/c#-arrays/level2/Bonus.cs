using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level2
{
    internal class Bonus
    {
        static void Main()
        {
            double[] sal = new double[10];
            double[] yrs = new double[10];
            double[] bon = new double[10];
            double[] newSal = new double[10];

            double totBon = 0;
            double totOld = 0;
            double totNew = 0;

            for (int i = 0; i < 10; i++)
            {
                sal[i] = Convert.ToDouble(Console.ReadLine());
                yrs[i] = Convert.ToDouble(Console.ReadLine());

                if (sal[i] <= 0 || yrs[i] < 0)
                {
                    i--;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (yrs[i] > 5)
                    bon[i] = sal[i] * 0.05;
                else
                    bon[i] = sal[i] * 0.02;

                newSal[i] = sal[i] + bon[i];

                totBon += bon[i];
                totOld += sal[i];
                totNew += newSal[i];
            }

            Console.WriteLine(totOld);
            Console.WriteLine(totBon);
            Console.WriteLine(totNew);
        }
    }
}
