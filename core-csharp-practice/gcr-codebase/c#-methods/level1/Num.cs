using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class Num
    {
        public int CheckNum(int n)
        {
            if (n > 0)
                return 1;
            else if (n < 0)
                return -1;
            else
                return 0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());

            Num obj = new Num();
            int res = obj.CheckNum(n);

            Console.WriteLine(res);
        }
    }
}
