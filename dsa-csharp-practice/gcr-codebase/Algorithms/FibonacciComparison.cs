using System;

class FibonacciComparison
{
    static void Main()
    {
        int[] testValues = { 10, 30 };

        foreach (int n in testValues)
        {
            Console.WriteLine("\nFibonacci Number: " + n);

            // -------- Recursive Fibonacci --------
            DateTime startRecursive = DateTime.Now;
            int recResult = FibonacciRecursive(n);
            DateTime endRecursive = DateTime.Now;

            double recursiveTime =
                (endRecursive - startRecursive).TotalMilliseconds;

            // Output Time (Approx):
            // N = 10 -> ~1 ms
            // N = 30 -> ~5000 ms (5 seconds)
            // N = 50 -> Unfeasible (>1 hour)

            // -------- Iterative Fibonacci --------
            DateTime startIterative = DateTime.Now;
            int itrResult = FibonacciIterative(n);
            DateTime endIterative = DateTime.Now;

            double iterativeTime =
                (endIterative - startIterative).TotalMilliseconds;

            // Output Time (Approx):
            // N = 10 -> ~0.01 ms
            // N = 30 -> ~0.05 ms
            // N = 50 -> ~0.1 ms

            Console.WriteLine("Recursive Result: " + recResult);
            Console.WriteLine("Iterative Result: " + itrResult);

            Console.WriteLine("Recursive Time (ms): " + recursiveTime);
            Console.WriteLine("Iterative Time (ms): " + iterativeTime);
        }
    }

    // -------- Recursive Fibonacci --------
    static int FibonacciRecursive(int n)
    {
        if (n <= 1)
            return n;

        return FibonacciRecursive(n - 1) +
               FibonacciRecursive(n - 2);
    }

    // -------- Iterative Fibonacci --------
    static int FibonacciIterative(int n)
    {
        if (n <= 1)
            return n;

        int a = 0, b = 1, sum = 0;

        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }
}
