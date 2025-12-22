using System;
class EmployeeBonus
{
    static void Main()
    {
        double sal=double.Parse(Console.ReadLine());
        int year=int.Parse(Console.ReadLine());
        if(year>5)
            Console.WriteLine(sal*0.05);
        else
            Console.WriteLine(0);
    }
}
