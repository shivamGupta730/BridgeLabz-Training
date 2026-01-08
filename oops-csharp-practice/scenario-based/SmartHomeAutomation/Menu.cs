using System;

namespace BridgeLabzTraining.scenrio_based_problem.SmartHomeAutomation
{
    internal class Menu
    {
     
        SmartHomeUtility home = new SmartHomeUtility();

        public void Start()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- SMART HOME AUTOMATION MENU ---");
                Console.WriteLine("1. Add Light");
                Console.WriteLine("2. Add Fan");
                Console.WriteLine("3. Add AC");
                Console.WriteLine("4. Turn ON all appliances");
                Console.WriteLine("5. Turn OFF all appliances");
                Console.WriteLine("6. Show all appliances");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Light name: ");
                        home.AddAppliance(new Light(Console.ReadLine()));
                        break;

                    case 2:
                        Console.Write("Enter Fan name: ");
                        home.AddAppliance(new Fan(Console.ReadLine()));
                        break;

                    case 3:
                        Console.Write("Enter AC name: ");
                        home.AddAppliance(new AC(Console.ReadLine()));
                        break;

                    case 4:
                        home.TurnOnAll();
                        break;

                    case 5:
                        home.TurnOffAll();
                        break;

                    case 6:
                        home.ShowAppliances();
                        break;

                    case 0:
                        Console.WriteLine("Exiting Smart Home Automation...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }

            } while (choice != 0);
        }
    }
}
