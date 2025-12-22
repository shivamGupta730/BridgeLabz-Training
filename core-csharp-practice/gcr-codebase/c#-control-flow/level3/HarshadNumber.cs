using System;
class HarshadNumber
{
    static void Main()
    {
        int origNum = int.Parse(Console.ReadLine());
        int num=origNum;
        int sum=0;
        while(num!=0){
            int rem=num%10;
            sum=sum+rem;
            num=num/10;
             
        }
        if(origNum%sum==0){
            Console.WriteLine("Harshad number");
        }
        else{
            Console.WriteLine("Not Harshad number");
        }
      
    }
}
