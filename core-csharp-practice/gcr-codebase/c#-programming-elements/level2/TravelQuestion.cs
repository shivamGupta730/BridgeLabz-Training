using System;

class TravelQuestion
{
    static void Main()
    {
        string name, from, via, to;
        double d1, d2, td;
        int t1, t2, tt;

        name = Console.ReadLine();
        from = Console.ReadLine();
        via = Console.ReadLine();
        to = Console.ReadLine();

        d1 = Convert.ToDouble(Console.ReadLine());
        t1 = Convert.ToInt32(Console.ReadLine());

        d2 = Convert.ToDouble(Console.ReadLine());
        t2 = Convert.ToInt32(Console.ReadLine());

        td = d1 + d2;
        tt = t1 + t2;

        Console.WriteLine("The results of the trip are: " + td +
                          " km, " + tt + " minutes for journey from " +
                          from + " to " + to + " via " + via);
    }
}
