using System;

namespace AddressBookSystem
{
    // UC5: Menu supports multiple contacts
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
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    addressBookUtility.AddContact();    // UC5
                }
                else if (choice == "2")
                {
                    addressBookUtility.EditContact();   // UC3
                }
                else if (choice == "3")
                {
                    addressBookUtility.DeleteContact(); // UC4
                }
                else if (choice == "4")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice, try again");
                }
            }
        }
    }
}
