using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook
{
    // UC2–UC12: Business Logic Class
    class AddressBookUtility : IAddressBook
    {
        // UC5: Collection to store multiple contacts
        private List<Contact> contacts = new List<Contact>();

        // UC2: Add Contact
        // UC7: Duplicate Check
        public void AddContact(Contact c)
        {
            if (contacts.Any(x => x.FirstName == c.FirstName &&
                                  x.LastName == c.LastName))
            {
                Console.WriteLine("Duplicate Contact Not Allowed");
                return;
            }

            contacts.Add(c);
            Console.WriteLine("Contact Added Successfully");
        }

        // UC3: Edit existing contact using first name
        public void EditContact(string name)
        {
            var c = contacts.FirstOrDefault(x => x.FirstName == name);
            if (c != null)
            {
                Console.Write("Enter new City: ");
                c.City = Console.ReadLine();
                Console.WriteLine("Contact Updated");
            }
            else
            {
                Console.WriteLine("Contact Not Found");
            }
        }

        // UC4: Delete contact using first name
        public void DeleteContact(string name)
        {
            contacts.RemoveAll(x => x.FirstName == name);
            Console.WriteLine("Contact Deleted");
        }

        // UC5: Display all contacts
        public void DisplayContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No Contacts Available");
                return;
            }

            foreach (var c in contacts)
                Console.WriteLine(c);
        }

        // UC8: Search person by City or State
        public void SearchByCityOrState(string value)
        {
            var result = contacts.Where(c => c.City == value || c.State == value);
            foreach (var c in result)
                Console.WriteLine(c);
        }

        // UC9 + UC10: Count persons by City
        public void CountByCity()
        {
            var result = contacts.GroupBy(c => c.City);
            foreach (var g in result)
                Console.WriteLine($"{g.Key} : {g.Count()}");
        }

        // UC11: Sort contacts alphabetically by name
        public void SortByName()
        {
            contacts = contacts.OrderBy(c => c.FirstName).ToList();
            Console.WriteLine("Sorted by Name");
        }

        // UC12: Sort contacts by City
        public void SortByCity()
        {
            contacts = contacts.OrderBy(c => c.City).ToList();
            Console.WriteLine("Sorted by City");
        }
    }
}
