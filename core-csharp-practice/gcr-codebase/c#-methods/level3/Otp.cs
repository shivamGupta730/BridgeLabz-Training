using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class Otp
    {
        public static int Gen()
        {
            Random r = new Random();
            return r.Next(100000, 1000000);
        }

        public static bool IsUnique(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                        return false;
                }
            }
            return true;
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];

            for (int i = 0; i < 10; i++)
            {
                a[i] = Otp.Gen();
                Console.WriteLine("OTP " + (i + 1) + " = " + a[i]);
            }

            if (Otp.IsUnique(a))
                Console.WriteLine("All OTPs are unique");
            else
                Console.WriteLine("Duplicate OTP found");
        }
    }
}
