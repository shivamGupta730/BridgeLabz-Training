using System;

class ConvertPoundsToKilogram
{
    static void Main()
    {
        double pounds;
        pounds = Convert.ToDouble(Console.ReadLine());

        double kg = pounds / 2.2;

        Console.WriteLine("The weight of the person in pounds is " + pounds +
                          " and in kg is " + kg);
    }
}
