using System;

class SquarePerimeter
{
    static void Main()
    {
        double peri = Convert.ToDouble(Console.ReadLine());
        double side = peri / 4;
        Console.WriteLine("The length of the side is " + side + " whose perimeter is " + peri);
    }
}
