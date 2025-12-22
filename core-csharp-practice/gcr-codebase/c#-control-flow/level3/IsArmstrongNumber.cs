using System;
class IsArmstrongNumber
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int origNum=num;
        int sum=0;
        while(origNum!=0){
            int rem=origNum%10;
            sum=sum+(rem*rem*rem);
            origNum=origNum/10;
        }
        if(sum==num){
            Console.WriteLine("Armstrong Number");
        }
        else{
            Console.WriteLine("Not Armstrong Number");
        }
    }
}
