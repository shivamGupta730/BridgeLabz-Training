//using System;

//namespace basic.TrafficManager
//{
//    internal class TrafficMenu
//    {
//        TrafficUtility traffic = new TrafficUtility();

//        public void Start()
//        {
//            int choice;

//            do
//            {
//                ShowMenu();
//                choice = int.Parse(Console.ReadLine());

//                switch (choice)
//                {
//                    case 1:
//                        Console.Write("Enter vehicle id: ");
//                        int id = int.Parse(Console.ReadLine());
//                        traffic.AddVehicle(id);
//                        break;

//                    case 2:
//                        traffic.RemoveVehicle();
//                        break;

//                    case 3:
//                        traffic.DisplayRoundabout();
//                        break;

//                    case 4:
//                        Console.WriteLine("Exiting Traffic Manager");
//                        break;

//                    default:
//                        Console.WriteLine("Invalid choice");
//                        break;
//                }

//            } while (choice != 4);
//        }

//        private void ShowMenu()
//        {
//            Console.WriteLine("\n--- Traffic Manager Menu ---");
//            Console.WriteLine("1. Add Vehicle");
//            Console.WriteLine("2. Remove Vehicle");
//            Console.WriteLine("3. Display Roundabout");
//            Console.WriteLine("4. Exit");
//        }
//    }
//}
