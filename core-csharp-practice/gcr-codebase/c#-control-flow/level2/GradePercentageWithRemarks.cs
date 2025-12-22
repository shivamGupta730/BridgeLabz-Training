using System;
class GradePercentageWithRemarks
{
        static void Main()
    {
        int phy=int.Parse(Console.ReadLine());
        int chem=int.Parse(Console.ReadLine());
        int math=int.Parse(Console.ReadLine());
        int total=phy+chem+math;
        double avg=total/3.0;
        Console.WriteLine("Average Mark: "+avg);
        if(avg>=80)
            Console.WriteLine("Grade: A\nRemarks: Level 4");
        else if(avg>=70)
            Console.WriteLine("Grade: B\nRemarks: Level 3");
        else if(avg>=60)
            Console.WriteLine("Grade: C\nRemarks: Level 2");
        else if(avg>=50)
            Console.WriteLine("Grade: D\nRemarks: Level 1");
        else if(avg>=40)
            Console.WriteLine("Grade: E\nRemarks: Level 1-");
        else
            Console.WriteLine("Grade: R\nRemarks: Remedial");
    }
}
