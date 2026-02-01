namespace AddressBook
{
    // UC2–UC5: Interface for Address Book operations
    interface IAddressBook
    {
        void AddContact(Contact contact);     // UC2
        void EditContact(string name);        // UC3
        void DeleteContact(string name);      // UC4
        void DisplayContacts();               // UC5
    }
}
