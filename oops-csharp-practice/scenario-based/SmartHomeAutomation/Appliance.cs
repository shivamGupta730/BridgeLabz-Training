using System;

namespace BridgeLabzTraining.scenrio_based_problem.SmartHomeAutomation
{
    // Base abstract class for all appliances
    internal abstract class Appliance : IControllable
    {
        // Common property
        public string Name { get; set; }

        // Constructor
        public Appliance(string name)
        {
            Name = name;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();

        public override string ToString()
        {
            return "Appliance Name: " + Name + " | Type: " + this.GetType().Name;
        }
    }
}
