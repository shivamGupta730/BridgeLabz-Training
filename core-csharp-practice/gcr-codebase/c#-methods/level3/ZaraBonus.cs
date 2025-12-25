using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class ZaraBonus
    {
        public static double[,] Gen()
        {
            double[,] a = new double[10, 2];
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                a[i, 0] = r.Next(10000, 100000);
                a[i, 1] = r.Next(1, 11);
            }
            return a;
        }

        public static double[,] Calc(double[,] a)
        {
            double[,] b = new double[10, 2];

            for (int i = 0; i < 10; i++)
            {
                double sal = a[i, 0];
                double yrs = a[i, 1];
                double bonus;

                if (yrs > 5)
                    bonus = sal * 0.05;
                else
                    bonus = sal * 0.02;

                b[i, 0] = sal + bonus;
                b[i, 1] = bonus;
            }
            return b;
        }

        public static void Total(double[,] oldData, double[,] newData)
        {
            double os = 0, ns = 0, tb = 0;

            Console.WriteLine("OldSalary  Years  NewSalary  Bonus");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(
                    oldData[i, 0] + "     " +
                    oldData[i, 1] + "     " +
                    newData[i, 0] + "     " +
                    newData[i, 1]
                );

                os += oldData[i, 0];
                ns += newData[i, 0];
                tb += newData[i, 1];
            }

            Console.WriteLine("Total Old Salary = " + os);
            Console.WriteLine("Total New Salary = " + ns);
            Console.WriteLine("Total Bonus = " + tb);
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            double[,] oldData = ZaraBonus.Gen();
            double[,] newData = ZaraBonus.Calc(oldData);
            ZaraBonus.Total(oldData, newData);
        }
    }
}
