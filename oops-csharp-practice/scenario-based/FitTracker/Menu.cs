using System;

namespace BridgeLabzTraining.scenrio_based_problem.FitTracker
{
    internal class Menu
    {
        public static void Start(UserProfile user)
        {
            while (true)
            {
                Console.WriteLine("\n1. Add Cardio Workout");
                Console.WriteLine("2. Add Strength Workout");
                Console.WriteLine("3. Show Workouts");
                Console.WriteLine("4. Exit");

                Console.Write("Choose option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddCardio(user);
                        break;

                    case 2:
                        AddStrength(user);
                        break;

                    case 3:
                        user.ShowWorkouts();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        private static void AddCardio(UserProfile user)
        {
            Console.Write("Enter duration (minutes): ");
            int duration = int.Parse(Console.ReadLine());

            Console.Write("Enter distance (km): ");
            int distance = int.Parse(Console.ReadLine());

            user.AddWorkout(new CardioWorkout(duration, distance));
            Console.WriteLine("Cardio workout added");
        }

        private static void AddStrength(UserProfile user)
        {
            Console.Write("Enter duration (minutes): ");
            int duration = int.Parse(Console.ReadLine());

            Console.Write("Enter sets: ");
            int sets = int.Parse(Console.ReadLine());

            Console.Write("Enter reps: ");
            int reps = int.Parse(Console.ReadLine());

            user.AddWorkout(new StrengthWorkout(duration, sets, reps));
            Console.WriteLine("Strength workout added");
        }
    }
}
