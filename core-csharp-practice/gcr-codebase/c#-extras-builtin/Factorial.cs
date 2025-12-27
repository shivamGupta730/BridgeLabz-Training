using System;

class Factorial
{
    static void Main()
    {
        int n = ReadInput();
        int ans = CalculateFactorial(n);
        ShowOutput(ans);
    }

    static int ReadInput()
    {
        return int.Parse(Console.ReadLine());
    }

    static int CalculateFactorial(int n)
    {
        if (n == 0)
            return 1;

        return n * CalculateFactorial(n - 1);
    }

    static void ShowOutput(int result)
    {
        Console.WriteLine(result);
    }
}
