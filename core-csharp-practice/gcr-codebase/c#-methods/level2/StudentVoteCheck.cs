using System;

namespace BridgeLabzTraining.c__methods.level1
{
    public class StudentVoteCheck
    {
        public bool CanStudentVote(int age)
        {
            if (age < 0)
                return false;

            if (age >= 18)
                return true;

            return false;
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            StudentVoteCheck s = new StudentVoteCheck();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter age:");
                a[i] = int.Parse(Console.ReadLine());

                bool r = s.CanStudentVote(a[i]);

                if (r)
                    Console.WriteLine("Can Vote");
                else
                    Console.WriteLine("Cannot Vote");
            }
        }
    }
}
