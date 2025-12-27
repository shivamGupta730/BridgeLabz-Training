using System;

class FactorialProgram
{
    static void Main()
    {
        int num = ReadNumber();
        int result = FindFactorial(num);
        ShowResult(result);
    }

    static int ReadNumber()
    {
        return int.Parse(Console.ReadLine());
    }

    static int FindFactorial(int n)
    {
        if (n == 0)
            return 1;

        return n * FindFactorial(n - 1);
    }

    static void ShowResult(int res)
    {
        Console.WriteLine(res);
    }
}
