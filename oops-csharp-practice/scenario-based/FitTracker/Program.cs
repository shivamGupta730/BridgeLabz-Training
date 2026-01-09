using System;

namespace BridgeLabzTraining.scenrio_based_problem.FitTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User input in Main only
            Console.Write("Enter user name: ");
            string name = Console.ReadLine();

            Console.Write("Enter number of workouts to store: ");
            int size = int.Parse(Console.ReadLine());

            // Create UserProfile object
            UserProfile user = new UserProfile(name, size);

            // Call Menu
            Menu.Start(user);
        }
    }
}
