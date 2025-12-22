using System;

class RocketLauncherCount
{
    static void Main()
    {
        Console.WriteLine("Enter the number");
        int count=int.Parse(Console.ReadLine());
        while(count>=1){
            Console.WriteLine(count);
            count--;
        }
    }
}
