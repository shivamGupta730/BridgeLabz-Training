using System;

class ChocolateDivide
{
    static void Main()
    {
        int noOfChoc, noOfChild;
       noOfChoc = Convert.ToInt32(Console.ReadLine());
        noOfChild= Convert.ToInt32(Console.ReadLine());

        int eachChild = noOfChoc/ noOfChild;
        int remChoc = noOfChoc % noOfChild;

        Console.WriteLine("The number of chocolates each child gets is " + eachChild +
                          " and the number of remaining chocolates is " + remChoc);
    }
}
