using System;

namespace BridgeLabzTraining.scenrio_based_problem.FitTracker
{
    internal abstract class Workout : ITrackable
    {
        public int Duration;   // minutes

        // Constructor
        public Workout(int duration)
        {
            Duration = duration;
        }

        // Abstract method (will be implemented by child classes)
        public abstract int CalculateCalories();

        // Common display method
        public override string ToString()
        {
            return "Duration: " + Duration + " minutes";
        }
    }
}
