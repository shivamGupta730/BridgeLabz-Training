using System;

namespace ParcelTracker
{
    class Program
    {
        static void Main()
        {
            ParcelLinkedList parcel = new ParcelLinkedList();
            int choice;

            do
            {
                Console.WriteLine("\n1. Add Stage");
                Console.WriteLine("2. Add Checkpoint");
                Console.WriteLine("3. Track Parcel");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter stage name: ");
                        parcel.AddStage(Console.ReadLine());
                        break;

                    case 2:
                        Console.Write("Enter existing stage: ");
                        string after = Console.ReadLine();
                        Console.Write("Enter new checkpoint: ");
                        string stage = Console.ReadLine();
                        parcel.AddCheckpoint(after, stage);
                        break;

                    case 3:
                        parcel.TrackParcel();
                        break;
                }
            } while (choice != 0);
        }
    }
}
