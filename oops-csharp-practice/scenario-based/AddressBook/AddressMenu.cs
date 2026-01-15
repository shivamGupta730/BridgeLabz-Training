using System;

namespace AddressBookSystem
{
    // UC2: Menu class
    public class AddressMenu
    {
        private AddressBookUtility addressBookUtility = new AddressBookUtility();

        public void ShowMenu()
        {
            Console.WriteLine("1. Add Contact");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                addressBookUtility.AddContact();
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
    }
}
