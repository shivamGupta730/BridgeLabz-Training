using System;

namespace AddressBookSystem
{
    // UC2: Logic class to add contact
    public class AddressBookUtility : IAddressBook
    {
        private Contact contact;

        public void AddContact()
        {
            contact = new Contact();

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            if (firstName == "")
            {
                Console.WriteLine("First Name cannot be empty");
                return;
            }
            contact.FirstName = firstName;

            Console.Write("Enter Last Name: ");
            contact.LastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            contact.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            contact.City = Console.ReadLine();

            Console.Write("Enter State: ");
            contact.State = Console.ReadLine();

            Console.Write("Enter Zip: ");
            string zip = Console.ReadLine();
            if (zip.Length != 6)
            {
                Console.WriteLine("Zip must be 6 digits");
                return;
            }
            contact.Zip = zip;

            Console.Write("Enter Phone Number: ");
            string phone = Console.ReadLine();
            if (phone.Length != 10)
            {
                Console.WriteLine("Phone Number must be 10 digits");
                return;
            }
            contact.PhoneNumber = phone;

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            if (!email.Contains("@"))
            {
                Console.WriteLine("Invalid Email");
                return;
            }
            contact.Email = email;

            Console.WriteLine("\nContact Added Successfully\n");
            Console.WriteLine(contact.ToString());
        }
    }
}
