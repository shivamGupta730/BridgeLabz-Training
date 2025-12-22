using System;
class FactorialProgram
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
         if (num > 0)
        {
            int fact = 1;
           for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
          Console.WriteLine(fact);
        }
        else
        {
            Console.WriteLine("Not a natural number");
        }
    }
}
