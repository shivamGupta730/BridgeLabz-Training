using System;
using System.Collections.Generic;

namespace ExamProctor
{
    class Program
    {
        static void Main()
        {
            ExamService exam = new ExamService();
            Dictionary<int, string> correct = new Dictionary<int, string>();

            int choice;
            do
            {
                Console.WriteLine("\n1. Visit Question");
                Console.WriteLine("2. Submit Answer");
                Console.WriteLine("3. Add Correct Answer");
                Console.WriteLine("4. Show Navigation");
                Console.WriteLine("5. Calculate Score");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Question ID: ");
                        exam.VisitQuestion(int.Parse(Console.ReadLine()));
                        break;

                    case 2:
                        Console.Write("Enter Question ID: ");
                        int q = int.Parse(Console.ReadLine());
                        Console.Write("Enter Answer: ");
                        exam.SubmitAnswer(q, Console.ReadLine());
                        break;

                    case 3:
                        Console.Write("Enter Question ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Correct Answer: ");
                        correct[id] = Console.ReadLine();
                        break;

                    case 4:
                        exam.ShowNavigation();
                        break;

                    case 5:
                        Console.WriteLine("Score: " +
                            exam.CalculateScore(correct));
                        break;
                }
            } while (choice != 0);
        }
    }
}
