using System;

class ShoppingProductProgram
{
    static double discount;

    string productName;
    double price;
    int quantity;
    readonly int productId;

    ShoppingProductProgram(string productName, double price, int quantity, int productId)
    {
        this.productName = productName;
        this.price = price;
        this.quantity = quantity;
        this.productId = productId;
    }

    void ShowProduct(object obj)
    {
        if (obj is ShoppingProductProgram)
        {
            Console.WriteLine("Product: " + productName);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Quantity: " + quantity);
        }
    }

    static void Main()
    {
        Console.Write("Enter Discount Percentage: ");
        discount = double.Parse(Console.ReadLine());

        Console.Write("Enter Product Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Price: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Enter Quantity: ");
        int qty = int.Parse(Console.ReadLine());

        Console.Write("Enter Product ID: ");
        int id = int.Parse(Console.ReadLine());

        ShoppingProductProgram product =
            new ShoppingProductProgram(name, price, qty, id);

        Console.WriteLine("Discount: " + discount + "%");
        product.ShowProduct(product);
    }
}
