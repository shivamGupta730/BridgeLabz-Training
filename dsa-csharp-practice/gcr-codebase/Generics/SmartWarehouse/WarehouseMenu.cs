using System;

namespace SmartWarehouse
{
    public class WarehouseMenu
    {
        public void ShowMenu()
        {
            StorageUtility<WarehouseItem> storage =
                new StorageUtility<WarehouseItem>();

            int choice;
            do
            {
                Console.WriteLine("\n1. Add Electronics");
                Console.WriteLine("2. Add Grocery");
                Console.WriteLine("3. Show All Items");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Electronics e = new Electronics();
                        Console.Write("Enter Electronics Name: ");
                        e.Name = Console.ReadLine();
                        storage.AddItem(e);
                        break;

                    case 2:
                        Grocery g = new Grocery();
                        Console.Write("Enter Grocery Name: ");
                        g.Name = Console.ReadLine();
                        storage.AddItem(g);
                        break;

                    case 3:
                        Console.WriteLine("\n--- Warehouse Items ---");
                        storage.ShowItems();
                        break;
                }

            } while (choice != 0);
        }
    }
}
