using System;
class MultiplicationTableUsingFor
{
    static void Main()
    {
        int num=int.Parse(Console.ReadLine());
        for(int i=6;i<=9;i++)
            Console.WriteLine(num+" * "+i+" = "+(num*i));
    }
}
