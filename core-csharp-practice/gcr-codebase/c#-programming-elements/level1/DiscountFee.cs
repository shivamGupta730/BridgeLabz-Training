using System;

class DiscountFee
{
    static void Main(){
        float fee = 125000;
        float disPercent = 10;
        float discount = (fee * disPercent) / 100;
        float final = fee - discount;
        Console.WriteLine("The discount amount is INR " + discount +
                          " and final discounted fee is INR " + final);
    }
}
