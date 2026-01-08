using System;
using System.Collections.Generic;

namespace BridgeLabzTraining.scenrio_based_problem.SmartHomeAutomation
{
    // Utility class 
    internal class SmartHomeUtility
    {
        // Appliances ko store karne ke liye list
        private List<Appliance> appliances = new List<Appliance>();

        // Add any appliance (Light / Fan / AC)
        public void AddAppliance(Appliance appliance)
        {
            appliances.Add(appliance);
            Console.WriteLine(appliance + " added successfully.");
        }

        // Turn ON all appliances
        public void TurnOnAll()
        {
            if (appliances.Count == 0)
            {
                Console.WriteLine("No appliances available.");
                return;
            }

            foreach (Appliance a in appliances)
            {
                a.TurnOn();   // Polymorphism
            }
        }

        // Turn OFF all appliances
        public void TurnOffAll()
        {
            if (appliances.Count == 0)
            {
                Console.WriteLine("No appliances available.");
                return;
            }

            foreach (Appliance a in appliances)
            {
                a.TurnOff();  // Polymorphism
            }
        }

       
        public void ShowAppliances()
        {
            if (appliances.Count == 0)
            {
                Console.WriteLine("No appliances to show.");
                return;
            }

            Console.WriteLine("\n--- Appliance List ---");
            foreach (Appliance a in appliances)
            {
                Console.WriteLine(a);   // ToString() auto call
            }
        }
    }
}
