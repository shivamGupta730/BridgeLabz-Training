using System;

namespace AddressBook
{
    // UC2–UC12: Menu driven program
    class AddressBookMenu
    {
        AddressBookUtility utility = new AddressBookUtility();

        public void ShowMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("\n1 Add  2 Edit  3 Delete  4 Display");
                Console.WriteLine("5 Search City/State  6 Count City");
                Console.WriteLine("7 Sort By Name  8 Sort By City  0 Exit");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: // UC2
                        Contact c = new Contact();
                        Console.Write("First Name: "); c.FirstName = Console.ReadLine();
                        Console.Write("Last Name: "); c.LastName = Console.ReadLine();
                        Console.Write("City: "); c.City = Console.ReadLine();
                        Console.Write("State: "); c.State = Console.ReadLine();
                        Console.Write("Zip: "); c.Zip = Console.ReadLine();
                        Console.Write("Phone: "); c.Phone = Console.ReadLine();
                        Console.Write("Email: "); c.Email = Console.ReadLine();
                        utility.AddContact(c);
                        break;

                    case 2: // UC3
                        Console.Write("Enter Name: ");
                        utility.EditContact(Console.ReadLine());
                        break;

                    case 3: // UC4
                        Console.Write("Enter Name: ");
                        utility.DeleteContact(Console.ReadLine());
                        break;

                    case 4: // UC5
                        utility.DisplayContacts();
                        break;

                    case 5: // UC8
                        Console.Write("Enter City or State: ");
                        utility.SearchByCityOrState(Console.ReadLine());
                        break;

                    case 6: // UC9 + UC10
                        utility.CountByCity();
                        break;

                    case 7: // UC11
                        utility.SortByName();
                        break;

                    case 8: // UC12
                        utility.SortByCity();
                        break;
                }

            } while (choice != 0);
        }
    }
}
