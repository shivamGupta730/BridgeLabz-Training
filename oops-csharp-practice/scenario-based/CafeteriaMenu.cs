using System;

namespace BridgeLabzTraining.scenrio_based_problem
{
    // simple item class
    class Item
    {
        public string Name;
        public int Price;
    }

    // bill item with quantity
    class BillItem
    {
        public string Name;
        public int Price;
        public int Quantity;
    }

    internal class CafeteriaMenu
    {
        Item[] menu = new Item[10];
        BillItem[] bill = new BillItem[10];

        int billCount = 0;
        int totalBill = 0;

        static void Main(string[] args)
        {
            CafeteriaMenu cafe = new CafeteriaMenu();
            cafe.CreateMenu();
            cafe.ShowMenu();     // menu ek hi baar
            cafe.TakeOrder();
        }

        // menu create
        void CreateMenu()
        {
            menu[0] = new Item { Name = "Tea", Price = 10 };
            menu[1] = new Item { Name = "Coffee", Price = 20 };
            menu[2] = new Item { Name = "Samosa", Price = 20 };
            menu[3] = new Item { Name = "Sandwich", Price = 50 };
            menu[4] = new Item { Name = "Burger", Price = 60 };
            menu[5] = new Item { Name = "Pizza", Price = 150 };
            menu[6] = new Item { Name = "Pasta", Price = 60 };
            menu[7] = new Item { Name = "Cold Drink", Price = 30 };
            menu[8] = new Item { Name = "Ice Cream", Price = 50 };
            menu[9] = new Item { Name = "Cake", Price = 150 };
        }

        // menu display
        void ShowMenu()
        {
            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine("| No | Item Name       | Price         |");
            Console.WriteLine("+--------------------------------------+");

            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine(
                    "| " + (i + 1).ToString().PadRight(2) +
                    "| " + menu[i].Name.PadRight(15) +
                    "| Rs " + menu[i].Price.ToString().PadRight(11) + "|"
                );
            }

            Console.WriteLine("+--------------------------------------+");
        }

        // order taking
        void TakeOrder()
        {
            while (true)
            {
                Console.Write("\nEnter item number (STOP to finish): ");
                string input = Console.ReadLine();

                if (input.Equals("STOP", StringComparison.OrdinalIgnoreCase))
                    break;

                if (!int.TryParse(input, out int itemNo) || itemNo < 1 || itemNo > 10)
                {
                    Console.WriteLine("Invalid item number!");
                    continue;
                }

                Console.Write("Enter quantity: ");
                string qtyInput = Console.ReadLine();

                if (!int.TryParse(qtyInput, out int qty) || qty <= 0)
                {
                    Console.WriteLine("Invalid quantity!");
                    continue;
                }

                AddToBill(menu[itemNo - 1], qty);
            }

            PrintBill();
        }

        // add item to bill (merge quantity if same item)
        void AddToBill(Item item, int qty)
        {
            for (int i = 0; i < billCount; i++)
            {
                if (bill[i].Name == item.Name)
                {
                    bill[i].Quantity += qty;
                    totalBill += item.Price * qty;
                    return;
                }
            }

            bill[billCount] = new BillItem
            {
                Name = item.Name,
                Price = item.Price,
                Quantity = qty
            };

            totalBill += item.Price * qty;
            billCount++;
        }

        // final perfect bill
        void PrintBill()
        {
            if (billCount == 0)
            {
                Console.WriteLine("\nNo items ordered. Thank you!");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("+-------------------------------------------------+");
            Console.WriteLine("| No | Item Name       | Qty | Price   | Amount   |");
            Console.WriteLine("+-------------------------------------------------+");

            for (int i = 0; i < billCount; i++)
            {
                int amount = bill[i].Quantity * bill[i].Price;

                Console.WriteLine(
                    "| " + (i + 1).ToString().PadRight(2) +
                    "| " + bill[i].Name.PadRight(15) +
                    "| " + bill[i].Quantity.ToString().PadRight(4) +
                    "| Rs " + bill[i].Price.ToString().PadRight(4) +
                    "| Rs " + amount.ToString().PadRight(7) + "|"
                );
            }

            Console.WriteLine("+-------------------------------------------------+");
            Console.WriteLine(
                "| TOTAL                                   Rs " +
                totalBill.ToString().PadRight(7) + "|"
            );
            Console.WriteLine("+-------------------------------------------------+");
            Console.WriteLine("Thank you! Visit again ");
        }
    }
}
