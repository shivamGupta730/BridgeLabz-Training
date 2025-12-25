using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class Calendar
    {
        public static string GetMonthName(int m)
        {
            string[] n = {
                "January","February","March","April","May","June",
                "July","August","September","October","November","December"
            };
            return n[m - 1];
        }

        public static bool IsLeap(int y)
        {
            if (y % 400 == 0) return true;
            if (y % 100 == 0) return false;
            return y % 4 == 0;
        }

        public static int DaysInMonth(int m, int y)
        {
            int[] d = { 31,28,31,30,31,30,31,31,30,31,30,31 };

            if (m == 2 && IsLeap(y))
                return 29;

            return d[m - 1];
        }

        public static int FirstDay(int m, int y)
        {
            int d = 1;
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;
            return d0;
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter month:");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter year:");
            int y = int.Parse(Console.ReadLine());

            string mn = Calendar.GetMonthName(m);
            int days = Calendar.DaysInMonth(m, y);
            int fd = Calendar.FirstDay(m, y);

            Console.WriteLine();
            Console.WriteLine(mn + " " + y);
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            for (int i = 0; i < fd; i++)
                Console.Write("    ");

            for (int d = 1; d <= days; d++)
            {
                Console.Write($"{d,3} ");

                if ((d + fd) % 7 == 0)
                    Console.WriteLine();
            }
        }
    }
}
