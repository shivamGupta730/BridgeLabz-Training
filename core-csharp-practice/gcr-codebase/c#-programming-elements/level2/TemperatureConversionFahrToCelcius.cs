using System;

class TemperatureConversionFahrToCelcius
{
    static void Main()
    {
        double fahr;
        fahr = Convert.ToDouble(Console.ReadLine());

        double celResult = (fahr- 32) * 5 / 9;

        Console.WriteLine("The " + fahr + " Fahrenheit is " + celResult + " Celsius");
    }
}
