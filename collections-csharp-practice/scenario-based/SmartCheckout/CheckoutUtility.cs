using System;
using System.Collections.Generic;

class CheckoutUtility : ICheckoutService
{
    private Queue<Customer> customerQueue = new Queue<Customer>();

    // HashMaps
    private Dictionary<string, int> priceMap = new Dictionary<string, int>();
    private Dictionary<string, int> stockMap = new Dictionary<string, int>();

    public void AddItemToStore()
    {
        Console.Write("Enter item name: ");
        string item = Console.ReadLine();

        Console.Write("Enter price: ");
        int price = int.Parse(Console.ReadLine());

        Console.Write("Enter stock quantity: ");
        int stock = int.Parse(Console.ReadLine());

        priceMap[item] = price;
        stockMap[item] = stock;

        Console.WriteLine("Item added/updated successfully");
    }

    public void AddCustomer()
    {
        Customer customer = new Customer();
        customer.Items = new List<string>();

        Console.Write("Enter customer name: ");
        customer.Name = Console.ReadLine();

        Console.Write("Enter number of items: ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter item name: ");
            string item = Console.ReadLine();

            if (priceMap.ContainsKey(item))
                customer.Items.Add(item);
            else
                Console.WriteLine("Item not found in store");
        }

        customerQueue.Enqueue(customer);
        Console.WriteLine("Customer added to checkout queue");
    }

    public void ProcessCustomer()
    {
        if (customerQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Customer customer = customerQueue.Dequeue();
        int totalBill = 0;

        Console.WriteLine($"\nProcessing customer: {customer.Name}");

        foreach (string item in customer.Items)
        {
            if (stockMap[item] > 0)
            {
                totalBill += priceMap[item];
                stockMap[item]--;
            }
            else
            {
                Console.WriteLine($"{item} is out of stock");
            }
        }

        Console.WriteLine($"Total Bill: ₹{totalBill}");
    }

    public void DisplayQueue()
    {
        Console.WriteLine("\nCustomers in Queue:");
        foreach (var c in customerQueue)
        {
            Console.WriteLine(c.Name);
        }
    }
}
