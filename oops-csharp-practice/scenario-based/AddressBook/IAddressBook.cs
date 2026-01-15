namespace AddressBookSystem
{
    // UC2–UC9: Address Book interface
    public interface IAddressBook
    {
        void AddContact();
        void EditContact();
        void DeleteContact();
        void SearchByCityOrState();   // UC8
        void ViewByCityOrState();     // UC9
    }
}
