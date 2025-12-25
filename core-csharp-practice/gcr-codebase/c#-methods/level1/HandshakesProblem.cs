using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class HandshakesProblem
    {
        public int CalculateHandshakesNumber(int numOfStud)
        {
            return (numOfStud * (numOfStud - 1)) / 2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of students:");
            int numOfStud = int.Parse(Console.ReadLine());

            HandshakesProblem hs = new HandshakesProblem();
            int res= hs.CalculateHandshakesNumber(numOfStud);

            Console.WriteLine("Maximum number of handshakes = " + res);
        }
    }
}
