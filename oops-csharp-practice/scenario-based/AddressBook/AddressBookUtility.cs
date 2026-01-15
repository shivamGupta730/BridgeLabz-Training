using System;

namespace AddressBookSystem
{
    // UC3: Utility class
    public class AddressBookUtility : IAddressBook
    {
        private Contact contact;

        // UC2: Add contact
        public void AddContact()
        {
            contact = new Contact();

            Console.Write("Enter First Name: ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            contact.LastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            contact.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            contact.City = Console.ReadLine();

            Console.Write("Enter State: ");
            contact.State = Console.ReadLine();

            // Zip validation (repeat until correct)
            while (true)
            {
                Console.Write("Enter Zip (6 digits): ");
                string zip = Console.ReadLine();

                if (zip.Length == 6)
                {
                    contact.Zip = zip;
                    break;
                }
                Console.WriteLine("Invalid Zip, try again");
            }

            // Phone validation (repeat until correct)
            while (true)
            {
                Console.Write("Enter Phone Number (10 digits): ");
                string phone = Console.ReadLine();

                if (phone.Length == 10)
                {
                    contact.PhoneNumber = phone;
                    break;
                }
                Console.WriteLine("Invalid Phone Number, try again");
            }

            // Email validation
            while (true)
            {
                Console.Write("Enter Email: ");
                string email = Console.ReadLine();

                if (email.Contains("@"))
                {
                    contact.Email = email;
                    break;
                }
                Console.WriteLine("Invalid Email, try again");
            }

            Console.WriteLine("\nContact Added Successfully");
        }

        // UC3: Edit contact
        public void EditContact()
        {
            if (contact == null)
            {
                Console.WriteLine("No contact available");
                return;
            }

            Console.Write("Enter First Name to Edit: ");
            string name = Console.ReadLine();

            if (name != contact.FirstName)
            {
                Console.WriteLine("Contact not found");
                return;
            }

            Console.Write("Enter New City: ");
            contact.City = Console.ReadLine();

            Console.Write("Enter New State: ");
            contact.State = Console.ReadLine();

            // Phone validation during edit
            while (true)
            {
                Console.Write("Enter New Phone Number (10 digits): ");
                string phone = Console.ReadLine();

                if (phone.Length == 10)
                {
                    contact.PhoneNumber = phone;
                    break;
                }
                Console.WriteLine("Invalid Phone Number, try again");
            }

            Console.WriteLine("\nContact Updated Successfully");
            Console.WriteLine(contact.ToString());
        }
    }
}
