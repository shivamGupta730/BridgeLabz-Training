using System;

class PenQuestion
{
    static void Main()
    {
        int pen = 14;
        int student = 3;
        int penCount = pen / student;  
        int remain = pen % student;
        Console.WriteLine("The Pen Per Student is " + penCount +
                          " and the remaining pen not distributed is " + remain);
    }
}
