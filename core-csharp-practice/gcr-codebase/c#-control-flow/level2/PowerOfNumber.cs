using System;
class PowerOfNumber
{
    static void Main()
    {
        int num=int.Parse(Console.ReadLine());
        int pow=int.Parse(Console.ReadLine());
        int result=1;
        for(int i=1;i<=pow;i++)
            result=result*num;
        Console.WriteLine(result);
    }
}
