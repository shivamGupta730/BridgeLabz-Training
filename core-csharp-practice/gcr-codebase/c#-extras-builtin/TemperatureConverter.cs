using System;

class TemperatureConverter
{
    static void Main()
    {
        double temp = double.Parse(Console.ReadLine());
        char choice = Console.ReadLine()[0];

        if (choice == 'C' || choice == 'c')
            Console.WriteLine(ToCelsius(temp));
        else if (choice == 'F' || choice == 'f')
            Console.WriteLine(ToFahrenheit(temp));
        else
            Console.WriteLine("Invalid choice");
    }

    static double ToCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }

    static double ToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }
}
