using System;

class Menu
{
    private ICheckoutService service = new CheckoutUtility();

    public void ShowMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- Smart Checkout Menu ---");
            Console.WriteLine("1. Add Item to Store");
            Console.WriteLine("2. Add Customer");
            Console.WriteLine("3. Process Customer");
            Console.WriteLine("4. Display Queue");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    service.AddItemToStore();
                    break;
                case 2:
                    service.AddCustomer();
                    break;
                case 3:
                    service.ProcessCustomer();
                    break;
                case 4:
                    service.DisplayQueue();
                    break;
                case 0:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        } while (choice != 0);
    }
}
