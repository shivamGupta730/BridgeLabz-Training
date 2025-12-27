using System;

class DateCompare
{
    static void Main()
    {
        DateTime d1 = DateTime.Parse(Console.ReadLine());
        DateTime d2 = DateTime.Parse(Console.ReadLine());

        if (d1 < d2)
            Console.WriteLine("First date is before second date");
        else if (d1 > d2)
            Console.WriteLine("First date is after second date");
        else
            Console.WriteLine("Both dates are same");
    }
}
