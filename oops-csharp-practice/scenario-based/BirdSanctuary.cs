using System;

namespace EcoWingSanctuary
{
    // Interface for flying
    interface IFlyable
    {
        void Fly();
    }

    // Interface for swimming
    interface ISwimmable
    {
        void Swim();
    }

    // Base class
    class Bird
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public Bird(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Species: {Species}");
        }
    }

    class Eagle : Bird, IFlyable
    {
        public Eagle(string name) : base(name, "Eagle") { }

        public void Fly()
        {
            Console.WriteLine("This bird can fly");
        }
    }

    class Sparrow : Bird, IFlyable
    {
        public Sparrow(string name) : base(name, "Sparrow") { }

        public void Fly()
        {
            Console.WriteLine("This bird can fly");
        }
    }

    class Duck : Bird, ISwimmable
    {
        public Duck(string name) : base(name, "Duck") { }

        public void Swim()
        {
            Console.WriteLine("This bird can swim");
        }
    }

    class Penguin : Bird, ISwimmable
    {
        public Penguin(string name) : base(name, "Penguin") { }

        public void Swim()
        {
            Console.WriteLine("This bird can swim");
        }
    }

    class Seagull : Bird, IFlyable, ISwimmable
    {
        public Seagull(string name) : base(name, "Seagull") { }

        public void Fly()
        {
            Console.WriteLine("This bird can fly");
        }

        public void Swim()
        {
            Console.WriteLine("This bird can swim");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of birds: ");
            int count = int.Parse(Console.ReadLine());

            Bird[] birds = new Bird[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nEnter details for Bird {i + 1}");

                Console.Write("Enter bird name: ");
                string name = Console.ReadLine();

                Console.Write("Enter bird type (Eagle/Sparrow/Duck/Penguin/Seagull): ");
                string type = Console.ReadLine();

                if (type.Equals("Eagle", StringComparison.OrdinalIgnoreCase))
                    birds[i] = new Eagle(name);

                else if (type.Equals("Sparrow", StringComparison.OrdinalIgnoreCase))
                    birds[i] = new Sparrow(name);

                else if (type.Equals("Duck", StringComparison.OrdinalIgnoreCase))
                    birds[i] = new Duck(name);

                else if (type.Equals("Penguin", StringComparison.OrdinalIgnoreCase))
                    birds[i] = new Penguin(name);

                else if (type.Equals("Seagull", StringComparison.OrdinalIgnoreCase))
                    birds[i] = new Seagull(name);

                else
                {
                    Console.WriteLine("Invalid bird type, try again");
                    i--;
                }
            }

            Console.WriteLine("\n--- Bird Activities ---\n");

            foreach (Bird bird in birds)
            {
                bird.DisplayInfo();

                if (bird is IFlyable)
                {
                    ((IFlyable)bird).Fly();
                }

                if (bird is ISwimmable)
                {
                    ((ISwimmable)bird).Swim();
                }

                Console.WriteLine("----------------------");
            }

            Console.ReadLine();
        }
    }
}
