using System;

namespace BridgeLabzTraining.scenrio_based_problem
{
    internal class StudentScores
    {
        static void Main(string[] args)
        {
            // Object banaya kyunki methods non-static hain
            StudentScores obj = new StudentScores();

            // Students count lena
            int n = obj.getStudentCount();
            if (n == 0) return;

            // Marks input lena
            int[] marks = obj.getMarks(n);
            if (marks == null) return;

            // Average calculate
            double avg = obj.calculateAverage(marks);
            Console.WriteLine("Average Marks = " + avg);

            // Highest marks
            int high = obj.getHighest(marks);
            Console.WriteLine("Highest Marks = " + high);

            // Lowest marks
            int low = obj.getLowest(marks);
            Console.WriteLine("Lowest Marks = " + low);

            // Above average marks
            obj.printAboveAverage(marks, avg);
        }

        // Students count input
        private int getStudentCount()
        {
            Console.WriteLine("Enter number of students");
            int n;

            // Check: number valid hai ya nahi
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Invalid number of students");
                return 0;
            }

            return n;
        }

        // Marks input
        private int[] getMarks(int n)
        {
            int[] marks = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter marks of student " + (i + 1));

                // Check: numeric input
                if (!int.TryParse(Console.ReadLine(), out marks[i]))
                {
                    Console.WriteLine("Invalid input");
                    return null;
                }

                // Check: negative marks
                if (marks[i] < 0)
                {
                    Console.WriteLine("Negative marks not allowed");
                    return null;
                }
            }

            return marks;
        }

        // Average calculate
        private double calculateAverage(int[] marks)
        {
            int total = 0;

            for (int i = 0; i < marks.Length; i++)
            {
                total = total + marks[i];
            }

            return (double)total / marks.Length;
        }

        // Highest marks
        private int getHighest(int[] marks)
        {
            int high = marks[0];

            for (int i = 1; i < marks.Length; i++)
            {
                if (marks[i] > high)
                    high = marks[i];
            }

            return high;
        }

        // Lowest marks
        private int getLowest(int[] marks)
        {
            int low = marks[0];

            for (int i = 1; i < marks.Length; i++)
            {
                if (marks[i] < low)
                    low = marks[i];
            }

            return low;
        }

        // Above average marks print
        private void printAboveAverage(int[] marks, double avg)
        {
            Console.WriteLine("Marks above average:");

            bool found = false;

            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] > avg)
                {
                    Console.WriteLine(marks[i]);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No marks above average");
            }
        }
    }
}
