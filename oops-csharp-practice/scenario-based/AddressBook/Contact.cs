namespace AddressBook
{
    // UC1: Create Contact class with required fields
    class Contact
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public string Zip;
        public string Phone;
        public string Email;

        // UC11: Override ToString for displaying contact
        public override string ToString()
        {
            return $"{FirstName} {LastName}, {City}, {State}, {Zip}, {Phone}, {Email}";
        }
    }
}
