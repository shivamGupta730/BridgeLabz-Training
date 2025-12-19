using System;

class TriangleArea
{
    static void Main()
    {
        double b, h;
        b = Convert.ToDouble(Console.ReadLine());
        h = Convert.ToDouble(Console.ReadLine());

        double areaInInch = 0.5 * b * h;
        double areaInCm = areaInInch * 6.4516;

        Console.WriteLine(" area in inches  " + areaInInch +
                          " and  area in  centimeters  " + areaInCm);
    }
}
