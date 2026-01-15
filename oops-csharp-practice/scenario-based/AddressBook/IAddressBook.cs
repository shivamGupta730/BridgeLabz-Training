namespace AddressBookSystem
{
    // UC2–UC11: Address Book interface
    public interface IAddressBook
    {
        void AddContact();
        void EditContact();
        void DeleteContact();
        void SearchByCityOrState();   
        void ViewByCityOrState();     
        void CountByCityAndState();   
        void SortByName();            // UC11
    }
}
