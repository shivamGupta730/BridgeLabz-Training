using System;
class FizzBuzz
{
    static void Main()
    {
        int num=int.Parse(Console.ReadLine());
        if(num>0)
        {
            int i=1;
            while(i<=num)
            {
                if(i%3==0&&i%5==0)
                    Console.WriteLine("FizzBuzz");
                else if(i%3==0)
                    Console.WriteLine("Fizz");
                else if(i%5==0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
                i++;
            }
        }
        else
            Console.WriteLine("Not a positive number");
    }
}
