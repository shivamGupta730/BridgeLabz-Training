using System;

namespace CustomFurnitureManufacturing
{
    class MenuHandler
    {
        RodCutUtility utility;

        public MenuHandler(RodCutUtility utility)
        {
            this.utility = utility;
        }

        public void ShowMenu()
        {
            Console.Write("Enter Rod Length: ");
            int rodLength = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("\n1. Max Revenue");
                Console.WriteLine("2. Revenue with Waste");
                Console.WriteLine("3. Revenue + Minimum Waste");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.Calculate(rodLength);
                        break;

                    case 2:
                        utility.CalculateWithWaste(rodLength);
                        break;

                    case 3:
                        utility.CalculateWithMinWaste(rodLength);
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
