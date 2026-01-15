using System;

namespace AddressBookSystem
{
    // UC3: Menu with repeat option for wrong entry
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
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    addressBookUtility.AddContact();   // UC2
                }
                else if (choice == "2")
                {
                    addressBookUtility.EditContact();  // UC3
                }
                else if (choice == "3")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again");
                }
            }
        }
    }
}
