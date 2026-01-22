using System;

class FinallyBlockDemo
{
    static void Main()
    {
        try
        {
            Console.Write("Enter numerator: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Result: " + (a / b));
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Division by zero error");
        }
        finally
        {
            Console.WriteLine("Operation completed");
        }
    }
}
