using System;
class AbundantNumber
{
    static void Main()
    {
        int num=int.Parse(Console.ReadLine());
        int sum=0;

        for(int i=1;i<num;i++)
        {
            if(num%i==0)
                sum=sum+i;
        }

        if(sum>num)
            Console.WriteLine("Abundant Number");
        else
            Console.WriteLine("Not an Abundant Number");
    }
}
