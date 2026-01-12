using System;

namespace CustomFurnitureManufacturing
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number of rod price entries: ");
            int size = int.Parse(Console.ReadLine());

            RodPricing pricing = new RodPricing(size);

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter rod length: ");
                int length = int.Parse(Console.ReadLine());

                Console.Write("Enter price: ");
                int price = int.Parse(Console.ReadLine());

                pricing.AddPrice(length, price);
            }

            RodCutUtility utility = new RodCutUtility(pricing);
            MenuHandler menu = new MenuHandler(utility);

            menu.ShowMenu();
        }
    }
}
