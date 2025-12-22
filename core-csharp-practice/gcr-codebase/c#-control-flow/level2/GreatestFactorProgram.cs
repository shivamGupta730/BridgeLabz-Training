using System;
class GreatestFactorProgram
{
    static void Main()
    {
        int num=int.Parse(Console.ReadLine());
        int greatFactor=1;
        for(int i=num-1;i>=1;i--)
        {
            if(num%i==0)
            {
                greatFactor=i;
                break;
            }
        }
        Console.WriteLine(greatFactor);
    }
}
