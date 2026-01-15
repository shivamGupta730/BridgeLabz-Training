namespace AddressBookSystem
{
    // UC2–UC10: Address Book interface
    public interface IAddressBook
    {
        void AddContact();
        void EditContact();
        void DeleteContact();
        void SearchByCityOrState();   // UC8
        void ViewByCityOrState();     // UC9
        void CountByCityAndState();   // UC10
    }
}
