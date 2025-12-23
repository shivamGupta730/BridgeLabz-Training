using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level1
{
    internal class NumberCheck
    {
        static void Main(string[] args)
        {
            int[]num=new int[5]; ;
            //taking input
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("enter number " + (i + 1) + ": ");
                num[i]=int.Parse(Console.ReadLine());

             }
            Console.WriteLine();
            //checked if the number is positive , negative or zero and  even odd
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > 0)
                {
                    if (num[i] % 2 == 0)
                    {
                        Console.WriteLine(num[i] + " is positive and even");
                    }
                    else
                    {
                        Console.WriteLine(num[i] + " is positive and odd");
                    }
                }
                else if (num[i] < 0)
                {
                    Console.WriteLine(num[i] + " is negative");
                }
                else {
                    Console.WriteLine(num[i] + " is zero");
                }
            }
            Console.WriteLine();
            //checked the first and last element of array is equals or not
            if (num[0] == num.Length - 1)
            {
                Console.WriteLine("First and Last element are equal");
            }
            else if (num[0] > num.Length - 1)
            {
                Console.WriteLine("first element is greater than last");
            }
            else {
                Console.WriteLine("first element is smaller than last");
            }

        }
    }
}
