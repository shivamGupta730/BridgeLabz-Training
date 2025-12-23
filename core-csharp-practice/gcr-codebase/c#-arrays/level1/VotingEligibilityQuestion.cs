using System;
namespace BridgeLabzTraining.arrays.level1
{
    internal class VotingEligibilityQuestion
    {
        static void Main(string[] args)
        {
            int[] ages = new int[10];
            // Taking input for ages
            for (int i = 0; i < ages.Length; i++)
            {
                Console.Write("Enter the age of student " + (i + 1) + ": ");
                ages[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] < 0)
                {
                    Console.WriteLine("Invalid age");
                }
                else if (ages[i] >= 18)
                {
                    Console.WriteLine("The student with the age " + ages[i] + " can vote");
                }
                else
                {
                    Console.WriteLine("The student with the age " + ages[i] + " cannot vote");
                }
            }
        }
    }
}
