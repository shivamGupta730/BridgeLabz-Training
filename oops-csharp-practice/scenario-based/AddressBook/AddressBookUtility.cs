using System;

namespace AddressBookSystem
{
    // UC5: Utility class using array for multiple contacts
    public class AddressBookUtility : IAddressBook
    {
        private Contact[] contacts = new Contact[100]; 
        private int contactCount = 0;

        // UC5: Add multiple contacts
        public void AddContact()
        {
            if (contactCount >= contacts.Length)
            {
                Console.WriteLine("Address Book is full");
                return;
            }

            Contact contact = new Contact();

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

            contacts[contactCount] = contact;
            contactCount++;

            Console.WriteLine("\nContact Added Successfully");
        }

        // UC3: Edit contact by first name
        public void EditContact()
        {
            if (contactCount == 0)
            {
                Console.WriteLine("No contacts available");
                return;
            }

            Console.Write("Enter First Name to Edit: ");
            string name = Console.ReadLine();

            for (int i = 0; i < contactCount; i++)
            {
                if (contacts[i].FirstName == name)
                {
                    Console.Write("Enter New City: ");
                    contacts[i].City = Console.ReadLine();

                    Console.Write("Enter New State: ");
                    contacts[i].State = Console.ReadLine();

                    while (true)
                    {
                        Console.Write("Enter New Phone Number (10 digits): ");
                        string phone = Console.ReadLine();
                        if (phone.Length == 10)
                        {
                            contacts[i].PhoneNumber = phone;
                            break;
                        }
                        Console.WriteLine("Invalid Phone Number, try again");
                    }

                    Console.WriteLine("\nContact Updated Successfully");
                    return;
                }
            }

            Console.WriteLine("Contact not found");
        }

        // UC4: Delete contact by first name
        public void DeleteContact()
        {
            if (contactCount == 0)
            {
                Console.WriteLine("No contacts available");
                return;
            }

            Console.Write("Enter First Name to Delete: ");
            string name = Console.ReadLine();

            for (int i = 0; i < contactCount; i++)
            {
                if (contacts[i].FirstName == name)
                {
                    for (int j = i; j < contactCount - 1; j++)
                    {
                        contacts[j] = contacts[j + 1];
                    }

                    contacts[contactCount - 1] = null;
                    contactCount--;

                    Console.WriteLine("Contact Deleted Successfully");
                    return;
                }
            }

            Console.WriteLine("Contact not found");
        }
    }
}
