using System;

class Price
{
    static void Main()
    {
        double uPrice;
        int qty;
        uPrice = Convert.ToDouble(Console.ReadLine());
        qty = Convert.ToInt32(Console.ReadLine());

        double total = uPrice * qty;

        Console.WriteLine("The total purchase price is INR " + total +
                          " if the quantity " + qty+ " and unit price is INR " + uPrice);
    }
}
