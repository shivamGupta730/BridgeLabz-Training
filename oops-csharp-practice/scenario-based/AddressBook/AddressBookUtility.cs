using System;

namespace AddressBookSystem
{
    // UC6: Prevent duplicate contacts using name
    public class AddressBookUtility : IAddressBook
    {
        private Contact[] contacts = new Contact[50];
        private int contactCount = 0;

        // UC2 + UC5 + UC6
        public void AddContact()
        {
            if (contactCount >= contacts.Length)
            {
                Console.WriteLine("Address Book is full");
                return;
            }

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            // UC6: Duplicate check by first name
            for (int i = 0; i < contactCount; i++)
            {
                if (contacts[i].FirstName == firstName)
                {
                    Console.WriteLine("Contact with same name already exists");
                    return;
                }
            }

            Contact contact = new Contact();
            contact.FirstName = firstName;

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

            Console.WriteLine("Contact Added Successfully");
        }

        // UC3
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

                    Console.WriteLine("Contact Updated Successfully");
                    return;
                }
            }

            Console.WriteLine("Contact not found");
        }

        // UC4
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
