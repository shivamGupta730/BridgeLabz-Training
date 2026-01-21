class Menu
{
    private IRankService service = new RankUtility();

    public void ShowMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\n1. Add Student");
            Console.WriteLine("2. Generate Rank Sheet");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    service.AddStudent();
                    break;

                case 2:
                    service.GenerateRankList();
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
