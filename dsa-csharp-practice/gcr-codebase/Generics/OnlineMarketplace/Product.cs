using System;

namespace OnlineMarketplace
{
    public abstract class Product
    {
        private string name;
        private double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public abstract void Display();
    }

    public class Book : Product
    {
        public override void Display()
        {
            Console.WriteLine($"Book : {Name}, Price : {Price}");
        }
    }

    public class Clothing : Product
    {
        public override void Display()
        {
            Console.WriteLine($"Clothing : {Name}, Price : {Price}");
        }
    }
}
