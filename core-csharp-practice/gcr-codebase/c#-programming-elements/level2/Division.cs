using System;

class Division
{
    static void Main()
    {
        int num1, num2;
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());

        int qut = num1 / num2;
        int rem = num1 % num2;

        Console.WriteLine("The Quotient is " + qut + " and Remainder is " + rem +
                          " of two numbers " + num1 + " and " + num2);
    }
}
