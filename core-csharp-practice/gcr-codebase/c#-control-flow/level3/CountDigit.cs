using System;
class CountDigit
{
    static void Main()
    {
        int origNum = int.Parse(Console.ReadLine());
        int num=origNum;
        int count=0;
        while(num!=0){
            num=num/10;
            count++;
        }
        Console.WriteLine(count);
      
    }
}
