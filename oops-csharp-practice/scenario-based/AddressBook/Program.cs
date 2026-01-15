using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program\n");

            AddressMenu menu = new AddressMenu();
            menu.ShowMenu();

            
        }
    }
}
