using System;
using System.Xml.Linq;

namespace BridgeLabzTraining.scenrio_based_problem.SmartHomeAutomation
{
    // Fan is an Appliance
    internal class Fan : Appliance
    {
        // Constructor
        public Fan(string name) : base(name)
        {
        }

        // Fan ka apna ON behaviour
        public override void TurnOn()
        {
            Console.WriteLine(Name + " Fan ON hai (Medium speed)");
        }

        // Fan ka apna OFF behaviour
        public override void TurnOff()
        {
            Console.WriteLine(Name + " Fan OFF ho gaya");
        }
    }
}
