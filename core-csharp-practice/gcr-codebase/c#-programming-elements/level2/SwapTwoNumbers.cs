using System;

class SwapTwoNumbers
{
    static void Main()
    {
        int num1, num2, temp;
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());

        temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("The swapped numbers are " + num1 + " and " + num2);
    }
}
