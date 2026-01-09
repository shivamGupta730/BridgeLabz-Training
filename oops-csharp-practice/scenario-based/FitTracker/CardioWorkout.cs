using System;

namespace BridgeLabzTraining.scenrio_based_problem.FitTracker
{
    internal class CardioWorkout : Workout
    {
        public int Distance;   // km

        // Constructor
        public CardioWorkout(int duration, int distance) : base(duration)
        {
            Distance = distance;
        }

        // Calories calculation
        public override int CalculateCalories()
        {
            return Distance * 50;
        }

        // Display details
        public override string ToString()
        {
            return "Cardio Workout | Duration: " + Duration +
                   " minutes | Distance: " + Distance +
                   " km | Calories: " + CalculateCalories();
        }
    }
}
