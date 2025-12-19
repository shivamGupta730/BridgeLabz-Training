using System;

class IntegerOperation
{
    static void Main()
    {
        int a, b, c;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());

        int r1 = a + b * c;
        int r2 = a * b + c;
        int r3 = c + a / b;
        int r4 = a % b + c;

        Console.WriteLine("The results of Int Operations are " +
                          r1 + ", " + r2 + ", " + r3 + " and " + r4);
    }
}
