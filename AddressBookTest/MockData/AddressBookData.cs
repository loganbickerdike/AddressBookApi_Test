using AddressBookApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookTest.MockData
{
    public static class AddressBookData
    {
        public static AddressBook GetAddressBook()
        {
            return new AddressBook
            {
                FristName = "Elvis",
                LastName = "Presley",
                DOB = new DateTime(1977, 1, 8),
                HouseNumber = "1",
                StreetName = "Blue Street",
                Town = "London",
                PostCode = "LS1 5RP",
                HomePhone = "012746523548",
                MobilePhone = "07442016369",
                Email = "Elvis@gmail.com",
                PersonType = "Friend" 
            };
        }

        public static List<AddressBook> GetAddressBooks()
        {
            return new List<AddressBook>
            {
                new AddressBook
                {
                    FristName = "Elvis",
                    LastName = "Presley",
                    DOB = new DateTime(1977, 1, 8),
                    HouseNumber = "1",
                    StreetName = "Blue Street",
                    Town = "London",
                    PostCode = "LS1 5RP",
                    HomePhone = "012746523548",
                    MobilePhone = "07442016369",
                    Email = "Elvis@gmail.com",
                    PersonType = "Friend"
                },
                    new AddressBook
                {
                    FristName = "Bob",
                    LastName = "Dylan",
                    DOB = new DateTime(1977, 1, 8),
                    HouseNumber = "1",
                    StreetName = "Blue Street",
                    Town = "London",
                    PostCode = "LS1 5RP",
                    HomePhone = "012746523548",
                    MobilePhone = "07442016369",
                    Email = "Elvis@gmail.com",
                    PersonType = "Friend"
                }
            };
        }
    }
}
