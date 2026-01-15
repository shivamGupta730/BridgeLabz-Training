using System;

namespace AddressBookSystem
{
    // UC10: Menu updated for count by city and state
    public class AddressMenu
    {
        private AddressBookUtility addressBookUtility = new AddressBookUtility();

        public void ShowMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Search by City or State");
                Console.WriteLine("5. View by City or State");
                Console.WriteLine("6. Count by City and State");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                    addressBookUtility.AddContact();
                else if (choice == "2")
                    addressBookUtility.EditContact();
                else if (choice == "3")
                    addressBookUtility.DeleteContact();
                else if (choice == "4")
                    addressBookUtility.SearchByCityOrState();
                else if (choice == "5")
                    addressBookUtility.ViewByCityOrState();
                else if (choice == "6")
                    addressBookUtility.CountByCityAndState(); // UC10
                else if (choice == "7")
                    exit = true;
                else
                    Console.WriteLine("Invalid choice, try again");
            }
        }
    }
}
