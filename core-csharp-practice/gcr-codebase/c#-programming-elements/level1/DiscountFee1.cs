using System;

class DiscountFee1
{
    static void Main()
    {
        float fee = Convert.ToSingle(Console.ReadLine());
        float disPercent = Convert.ToSingle(Console.ReadLine());
        float discount = (fee * disPercent) / 100;
        float final = fee - discount;
        Console.WriteLine("The discount amount is INR " + discount +
                          " and final discounted fee is INR " + final);
    }
}
