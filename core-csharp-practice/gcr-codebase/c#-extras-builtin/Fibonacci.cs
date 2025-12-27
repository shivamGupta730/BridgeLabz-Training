using System;

class Fibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintFibonacci(n);
    }

    static void PrintFibonacci(int terms)
    {
        int a = 0, b = 1;

        for (int i = 1; i <= terms; i++)
        {
            Console.Write(a + " ");
            int c = a + b;
            a = b;
            b = c;
        }
    }
}
