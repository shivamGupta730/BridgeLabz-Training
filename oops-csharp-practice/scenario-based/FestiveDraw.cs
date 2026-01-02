using System;

namespace oops.selfPractice
{
    class LuckyDraw
    {
        public int number;

        // Method to check lucky number
        public bool CheckLuckyNumber(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return true;
            }
            return false;
        }
    }

    internal class FestiveDraw
    {
        public static void Main(string[] args)
        {
            LuckyDraw luck = new LuckyDraw();
            string choice = "yes";  

            do
            {
                Console.Write("Enter your number: ");

                // Invalid input check
                if (!int.TryParse(Console.ReadLine(), out luck.number))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    continue;
                }

                if (luck.number <= 0)
                {
                    Console.WriteLine("Invalid number! Enter a positive number.");
                    continue;
                }

                // Lucky number check
                if (luck.CheckLuckyNumber(luck.number))
                {
                    Console.WriteLine("Congratulations! You won a gift.");
                }
                else
                {
                    Console.WriteLine("Better luck next time.");
                }

                Console.Write("Do you want to continue? (yes/no): ");
                choice = Console.ReadLine().ToLower();

            } while (choice == "yes" || choice == "y");

            Console.WriteLine("Thank you for visiting the Diwali Mela.");
        }
    }
}
