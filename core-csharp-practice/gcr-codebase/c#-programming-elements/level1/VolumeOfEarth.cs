using System;

class VolumeOfEarth
{
    static void Main(){
        double radius = 6378;
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        double radiusMiles = radius * 0.621371;
        double volumeMiles = (4.0 / 3.0) * Math.PI * Math.Pow(radiusMiles, 3);
        Console.WriteLine("The volume of earth in cubic kilometers is " + volume +
                          " and cubic miles is " + volumeMiles);
    }
}
