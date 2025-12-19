using System;

class AthleteRunQuestion
{
    static void Main()
    {
        double s1, s2, s3;
        s1 = Convert.ToDouble(Console.ReadLine());
        s2 = Convert.ToDouble(Console.ReadLine());
        s3 = Convert.ToDouble(Console.ReadLine());

        double peri = s1 + s2 + s3;

        double dist = 5000; 

        double round = dist / peri;

        Console.WriteLine("The total number of rounds the athlete will run is " + round + " to complete 5 km");
    }
}
