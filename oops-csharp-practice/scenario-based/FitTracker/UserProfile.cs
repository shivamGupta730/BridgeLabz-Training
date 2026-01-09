using System;

namespace BridgeLabzTraining.scenrio_based_problem.FitTracker
{
    internal class UserProfile
    {
        public string Name;
        private Workout[] workouts;
        private int count = 0;

        // Constructor
        public UserProfile(string name, int size)
        {
            Name = name;
            workouts = new Workout[size];
        }

        // Add workout to array
        public void AddWorkout(Workout workout)
        {
            if (count < workouts.Length)
            {
                workouts[count] = workout;
                count++;
                Console.WriteLine("Workout added successfully");
            }
            else
            {
                Console.WriteLine("Workout list is full");
            }
        }

        // Display all workouts
        public void ShowWorkouts()
        {
            Console.WriteLine("\nWorkouts of " + Name);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(workouts[i]);
            }
        }
    }
}
