using System;

namespace SmartWarehouse
{
    public abstract class WarehouseItem
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract void Display();
    }

    public class Electronics : WarehouseItem
    {
        public override void Display()
        {
            Console.WriteLine("Electronics Item : " + Name);
        }
    }

    public class Grocery : WarehouseItem
    {
        public override void Display()
        {
            Console.WriteLine("Grocery Item : " + Name);
        }
    }
}
