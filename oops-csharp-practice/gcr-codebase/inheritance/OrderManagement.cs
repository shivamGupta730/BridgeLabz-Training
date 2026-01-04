using System;

class Order
{
    public int OrderId;
    public string OrderDate;
}

class ShippedOrder : Order
{
    public string TrackingNumber;
}

class DeliveredOrder : ShippedOrder
{
    public string DeliveryDate;

    public void GetOrderStatus()
    {
        Console.WriteLine("Delivered on: " + DeliveryDate);
    }
}

class Program
{
    static void Main()
    {
        DeliveredOrder d = new DeliveredOrder();

        Console.Write("Enter order id: ");
        d.OrderId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter order date: ");
        d.OrderDate = Console.ReadLine();

        Console.Write("Enter tracking number: ");
        d.TrackingNumber = Console.ReadLine();

        Console.Write("Enter delivery date: ");
        d.DeliveryDate = Console.ReadLine();

        d.GetOrderStatus();
    }
}
