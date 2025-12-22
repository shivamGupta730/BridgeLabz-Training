using System;

class RocketLauncher
{
    static void Main()
    {
        Console.WriteLine("Enter the number");
        int count = int.Parse(Console.ReadLine());

        for (int i = count; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}
