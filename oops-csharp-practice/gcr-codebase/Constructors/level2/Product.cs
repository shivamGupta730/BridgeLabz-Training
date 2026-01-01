using System;

public class Product
{
    // Instance variables (har object ka apna)
    private string productName;
    private double price;

    // Class variable (sab object ke liye common)
    public static int totalProducts = 0;

    // Constructor
    public Product(string productName, double price)
    {
        this.productName = productName;
        this.price = price;
        totalProducts++;
    }

    // Instance method
    public void DisplayProductDetails()
    {
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Price: " + price);
    }

    // Class method
    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products Created: " + totalProducts);
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        Console.Write("Enter product price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Product p1 = new Product(name, price);
        p1.DisplayProductDetails();

        Product.DisplayTotalProducts();
    }
}
