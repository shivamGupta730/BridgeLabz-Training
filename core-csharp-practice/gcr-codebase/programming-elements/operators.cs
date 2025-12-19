using System;

class Operators
{
    static void Main()
    {
        // Arithmetic operators
        int a = 10, b = 3;
        Console.WriteLine("Arithmetic:");
        Console.WriteLine(a + b); // add
        Console.WriteLine(a - b); // sub
        Console.WriteLine(a * b); // mul
        Console.WriteLine(a / b); // div
        Console.WriteLine(a % b); // mod

        // Relational operators
        Console.WriteLine("\nRelational:");
        Console.WriteLine(a == b);
        Console.WriteLine(a != b);
        Console.WriteLine(a > b);
        Console.WriteLine(a < b);
        Console.WriteLine(a >= b);
        Console.WriteLine(a <= b);

        // Logical operators
        bool x = true, y = false;
        Console.WriteLine("\nLogical:");
        Console.WriteLine(x && y); // and
        Console.WriteLine(x || y); // or
        Console.WriteLine(!x);     // not

        // Assignment operators
        int n = 10;
        Console.WriteLine("\nAssignment:");
        n += 5;
        Console.WriteLine(n);
        n -= 2;
        Console.WriteLine(n);
        n *= 2;
        Console.WriteLine(n);
        n /= 3;
        Console.WriteLine(n);

        // Unary
        int k = 5;
        Console.WriteLine("\nUnary:");
        Console.WriteLine(++k); // pre inc
        Console.WriteLine(k++); // post inc
        Console.WriteLine(--k); // pre dec
        Console.WriteLine(k--); // post dec

        // Ternary
        int p = 20, q = 15;
        int max = (p > q) ? p : q;
        Console.WriteLine("\nTernary:");
        Console.WriteLine(max);
    }
}
