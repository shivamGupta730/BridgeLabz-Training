using System;

class TempConversion
{
    static void Main()
    {
        double cel;
        cel = Convert.ToDouble(Console.ReadLine());

        double fahrResult = (cel * 9 / 5) + 32;

        Console.WriteLine("The " + cel + " Celsius is " + fahrResult + " Fahrenheit");
    }
}
