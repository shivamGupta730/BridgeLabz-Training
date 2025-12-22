using System;

class SumUntilZero
{
    static void Main()
    {
        double total = 0.0;

        Console.WriteLine("Enter the number");
        double num = double.Parse(Console.ReadLine());

        while (num != 0)
        {
            total = total + num;

            Console.WriteLine("Enter the number");
            num = double.Parse(Console.ReadLine());
        }

        Console.WriteLine(" the total sum is "+total);
    }
}
