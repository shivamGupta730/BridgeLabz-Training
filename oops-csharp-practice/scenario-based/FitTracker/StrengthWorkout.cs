using System;

namespace BridgeLabzTraining.scenrio_based_problem.FitTracker
{
    internal class StrengthWorkout : Workout
    {
        public int Sets;
        public int Reps;

        // Constructor
        public StrengthWorkout(int duration, int sets, int reps) : base(duration)
        {
            Sets = sets;
            Reps = reps;
        }

        // Calories calculation
        public override int CalculateCalories()
        {
            return Sets * Reps;
        }

        // Display details
        public override string ToString()
        {
            return "Strength Workout | Duration: " + Duration +
                   " minutes | Sets: " + Sets +
                   " | Reps: " + Reps +
                   " | Calories: " + CalculateCalories();
        }
    }
}
