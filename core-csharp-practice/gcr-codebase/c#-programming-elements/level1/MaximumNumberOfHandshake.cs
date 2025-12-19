using System;

class MaximumNumberOfHandshake
{
    static void Main()
    {
        int noOfStud;
        noOfStud = Convert.ToInt32(Console.ReadLine());

        int numberHandshakes = (noOfStud * (noOfStud - 1)) / 2;

        Console.WriteLine("The maximum number of handshakes is " + numberHandshakes);
    }
}
