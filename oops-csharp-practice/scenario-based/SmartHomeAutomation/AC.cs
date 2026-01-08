using System;

namespace BridgeLabzTraining.scenrio_based_problem.SmartHomeAutomation
{
    // AC is an Appliance
    internal class AC : Appliance
    {
        // Constructor
        public AC(string name) : base(name)
        {
        }

        // AC ka apna ON behaviour
        public override void TurnOn()
        {
            Console.WriteLine(Name + " AC ON hai (Cooling to 22°C)");
        }

        // AC ka apna OFF behaviour
        public override void TurnOff()
        {
            Console.WriteLine(Name + " AC OFF ho gaya (Power saving mode)");
        }
    }
}
