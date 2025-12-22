using System;

class IsSpringSeason
{
    static void Main()
    {
        int month = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());

        if (month == 3 && day >= 20)
        {
            Console.WriteLine("Its a Spring Season");
        }
        else if (month == 4 || month == 5)
        {
            Console.WriteLine("Its a Spring Season");
        }
        else if (month == 6 && day <= 20)
        {
            Console.WriteLine("Its a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}
