using System;

namespace basic.FitnessTracker
{
    internal class StepMenu
    {
        public void Show()
        {
            StepUtility utility = new StepUtility(4);

            utility.AddSteps();
            utility.Sort();
            utility.Display();
        }
    }
}
