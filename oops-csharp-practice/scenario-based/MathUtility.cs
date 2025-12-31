using System;

namespace BridgeLabzTraining.scenrio_based_problem
{
    internal class MathUtility
    {
        // Factorial method
        int Factorial(int n)
        {
            if (n < 0)
                return -1;

            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        // Prime check method
        bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        // GCD method
        int GCD(int a, int b)
        {
            int gcd = 1;
            int min = a < b ? a : b;

            for (int i = 1; i <= min; i++)
            {
                if (a % i == 0 && b % i == 0)
                    gcd = i;
            }
            return gcd;
        }

        // Fibonacci method
        int Fibonacci(int n)
        {
            if (n < 0)
                return -1;

            if (n == 0) return 0;
            if (n == 1) return 1;

            int a = 0, b = 1, c = 0;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        // Main method
        static void Main(string[] args)
        {
            MathUtility obj = new MathUtility();

            Console.WriteLine("1. Factorial");
            Console.WriteLine("2. Prime Check");
            Console.WriteLine("3. GCD");
            Console.WriteLine("4. Fibonacci");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter number: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int r = obj.Factorial(n);
                Console.WriteLine(r == -1 ? "Invalid number" : r.ToString());
            }
            else if (choice == 2)
            {
                Console.Write("Enter number: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(obj.IsPrime(n));
            }
            else if (choice == 3)
            {
                Console.Write("Enter first number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(obj.GCD(a, b));
            }
            else if (choice == 4)
            {
                Console.Write("Enter number: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int r = obj.Fibonacci(n);
                Console.WriteLine(r == -1 ? "Invalid number" : r.ToString());
            }
            else
            {
                Console.WriteLine("Wrong choice");
            }
        }
    }
}
