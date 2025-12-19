using System;

class CmToInchesAndMiles
{
    static void Main()
    {
        double cm = Convert.ToDouble(Console.ReadLine());
        double totalInch = cm / 2.54;
        int feet = (int)(totalInch / 12);
        double inch = totalInch % 12;
        Console.WriteLine("Your Height in cm is " + cm + " while in feet is " + feet + " and inches is " + inch);
    }
}
