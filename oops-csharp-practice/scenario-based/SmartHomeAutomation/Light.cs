using System;
using System.Xml.Linq;

namespace BridgeLabzTraining.scenrio_based_problem.SmartHomeAutomation
{
   
    internal class Light : Appliance
    {
        // Constructor
        public Light(string name) : base(name)
        {
        }

        // Light ka apna ON behaviour
        public override void TurnOn()
        {
            Console.WriteLine(Name + " Light ON hai (Soft brightness)");
        }

        // Light ka apna OFF behaviour
        public override void TurnOff()
        {
            Console.WriteLine(Name + " Light OFF ho gayi");
        }
    }
}
