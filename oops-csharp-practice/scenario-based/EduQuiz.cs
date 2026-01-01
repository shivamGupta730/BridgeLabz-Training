using System;

namespace BridgeLabzTraining.scenrio_based_problem
{
    internal class EduQuiz
    {
        static void Main(string[] args)
        {
            // Questions list
            string[] questions =
            {
                "1. Capital of India?",
                "2. Which language is used for Android?",
                "3. Which keyword is used to create object in C#?",
                "4. What is 2 + 2?",
                "5. Company that developed C#?",
                "6. Symbol for single line comment?",
                "7. CLR stands for?",
                "8. Data type for true/false?",
                "9. Entry point of C# program?",
                "10. Operator used for comparison?"
            };

            // Options for each question
            string[,] options =
            {
                { "A. Delhi", "B. Mumbai", "C. Kolkata", "D. Chennai" },
                { "A. Python", "B. Java", "C. C#", "D. Swift" },
                { "A. class", "B. this", "C. new", "D. object" },
                { "A. 4", "B. 3", "C. 5", "D. 6" },
                { "A. Google", "B. Apple", "C. Amazon", "D. Microsoft" },
                { "A. ##", "B. //", "C. /* */", "D. --" },
                { "A. Common Language Runtime", "B. Code Language Run", "C. Common Logic Rule", "D. Class Level Runtime" },
                { "A. int", "B. string", "C. bool", "D. double" },
                { "A. Start()", "B. Run()", "C. Begin()", "D. Main()" },
                { "A. ==", "B. =", "C. +", "D. *" }
            };

            // Correct answers (Answer key)
            string[] correctAnswers = { "A", "B", "C", "A", "D", "B", "A", "C", "D", "A" };

            // Student answers (user input)
            string[] studentAnswers = new string[10];

            Console.WriteLine("Quiz started");
            Console.WriteLine("Instruction: Enter only A, B, C or D\n");

            // Question loop
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);

                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(options[i, j]);
                }

                // Edge case handling for input
                while (true)
                {
                    Console.Write("Your Answer: ");
                    string input = Console.ReadLine();

                    if (!string.IsNullOrEmpty(input) &&
                        (input.Equals("A", StringComparison.OrdinalIgnoreCase) ||
                         input.Equals("B", StringComparison.OrdinalIgnoreCase) ||
                         input.Equals("C", StringComparison.OrdinalIgnoreCase) ||
                         input.Equals("D", StringComparison.OrdinalIgnoreCase)))
                    {
                        studentAnswers[i] = input;
                        break; // valid answer mila
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter A, B, C or D.");
                    }
                }

                Console.WriteLine();
            }

            // Score calculation
            int score = CalculateScore(correctAnswers, studentAnswers);

            // Percentage
            double percentage = (score * 100.0) / correctAnswers.Length;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Score: " + score + "/" + correctAnswers.Length);
            Console.WriteLine("Percentage: " + percentage + "%");

            // Pass / Fail
            if (percentage >= 50)
            {
                Console.WriteLine("Result: PASS");
            }
            else
            {
                Console.WriteLine("Result: FAIL");
            }
        }

        // Method to calculate score and give feedback
        static int CalculateScore(string[] correct, string[] student)
        {
            int score = 0;

            for (int i = 0; i < correct.Length; i++)
            {
                if (correct[i].Equals(student[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Question " + (i + 1) + ": Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Question " + (i + 1) + ": Incorrect");
                }
            }

            return score;
        }
    }
}
