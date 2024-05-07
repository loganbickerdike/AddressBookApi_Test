using AddressBookApi.Helpers;
using AddressBookApi.Models;

namespace AddressBookApi_Test.Data
{
    public static class SeedData
    {
        public static void CreateSeedData()
        {
            var data = new List<AddressBook>
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

            JsonHelper<AddressBook>.CreateFile(data);
        }
    }
}
