using System;

class Calculator
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        char op = Console.ReadLine()[0];

        if (op == '+')
            Console.WriteLine(Add(a, b));
        else if (op == '-')
            Console.WriteLine(Subtract(a, b));
        else if (op == '*')
            Console.WriteLine(Multiply(a, b));
        else if (op == '/')
            Console.WriteLine(Divide(a, b));
        else
            Console.WriteLine("Invalid operator");
    }

    static int Add(int x, int y)
    {
        return x + y;
    }

    static int Subtract(int x, int y)
    {
        return x - y;
    }

    static int Multiply(int x, int y)
    {
        return x * y;
    }

    static int Divide(int x, int y)
    {
        return x / y;
    }
}
