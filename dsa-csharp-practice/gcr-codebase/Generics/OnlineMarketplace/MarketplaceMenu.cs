using System;

namespace OnlineMarketplace
{
    public class MarketplaceMenu
    {
        public void ShowMenu()
        {
            CatalogUtility<Product> catalog =
                new CatalogUtility<Product>();

            int choice;
            do
            {
                Console.WriteLine("\n1. Add Book");
                Console.WriteLine("2. Add Clothing");
                Console.WriteLine("3. Apply Discount");
                Console.WriteLine("4. Show Products");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Book b = new Book();
                        Console.Write("Enter Book Name: ");
                        b.Name = Console.ReadLine();
                        Console.Write("Enter Price: ");
                        b.Price = double.Parse(Console.ReadLine());
                        catalog.AddProduct(b);
                        break;

                    case 2:
                        Clothing c = new Clothing();
                        Console.Write("Enter Clothing Name: ");
                        c.Name = Console.ReadLine();
                        Console.Write("Enter Price: ");
                        c.Price = double.Parse(Console.ReadLine());
                        catalog.AddProduct(c);
                        break;

                    case 3:
                        Console.Write("Enter Discount %: ");
                        double d = double.Parse(Console.ReadLine());
                        catalog.ApplyDiscount(d);
                        break;

                    case 4:
                        Console.WriteLine("\n--- Product List ---");
                        catalog.ShowProducts();
                        break;
                }

            } while (choice != 0);
        }
    }
}
