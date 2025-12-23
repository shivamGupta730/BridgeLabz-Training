using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabzTraining.arrays.level1
{
    internal class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int num;
            int[] mulTable = new int[10];
            Console.WriteLine("enter the number");
            num=int.Parse(Console.ReadLine());

            //Store the table in array
            for (int i = 1; i <=10; i++)
            {
                mulTable[i-1] = num * i;

            }
            //print the table
            Console.WriteLine();
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + mulTable[i - 1]);
            }
        }
    }
}
