using System;

class TotalIncomeOfPerson
{
    static void Main()
    {
        double slry, bonus;
        slry = Convert.ToDouble(Console.ReadLine());
        bonus = Convert.ToDouble(Console.ReadLine());

        double inc = slry + bonus;

        Console.WriteLine("The salary is INR " + slry + " and bonus is INR " + bonus +
                          ". Hence Total Income is INR " + inc);
    }
}
