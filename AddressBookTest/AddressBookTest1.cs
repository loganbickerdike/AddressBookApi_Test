using AddressBookApi.Helpers;
using AddressBookApi.Models;
using AddressBookApi.Services;
using AddressBookTest.MockData;

namespace AddressBookTest
{
    public class AddressBookTest1
    {
        [Fact]
        public void AddressBookTest_Crate()
        {
            // Arrange
            var addressbook = AddressBookData.GetAddressBook();

            // Act 
            new AddressBookService().Create(addressbook);
            var newAddress = JsonHelper<AddressBook>.GetFile();

            // Assert
            Assert.Equivalent(addressbook, newAddress);
        }

        [Fact]
        public void AddressBookTest_Get()
        {
            // Arrange 
            var addresses = AddressBookData.GetAddressBooks();
            JsonHelper<AddressBook>.CreateFile(addresses);

            // Act 
            var bobDylan = new AddressBookService().Get("Bob");

            // Assert
            Assert.Equivalent(bobDylan, addresses.Where(x => x.FristName == "Bob").FirstOrDefault());
        }

        [Fact]
        public void AddressBookTest_Update()
        {
            // Arrange 
            var addressBooks = AddressBookData.GetAddressBooks();

            var addressbookUpdate = new AddressBook
            {
                FristName = "Elvis",
                LastName = "Presley",
                DOB = new DateTime(1977, 1, 8),
                HouseNumber = "1",
                StreetName = "Blue Street Blues",
                Town = "London",
                PostCode = "LS1 5RP",
                HomePhone = "012746523549",
                MobilePhone = "07442016369",
                Email = "Elvis@gmail.com",
                PersonType = "Friend"
            };

            // Act 
            JsonHelper<AddressBook>.CreateFile(addressBooks);
            new AddressBookService().Update(addressbookUpdate);
            var addressBooksUpdate = JsonHelper<AddressBook>.GetFiles();

            // Assert
            Assert.False(addressBooksUpdate?.First(x => x.FristName == "Elvis").StreetName == addressBooks.First(x => x.FristName == "Elvis").StreetName);

        }

        [Fact]
        public void AddressBookTest_Delete()
        {
            // Arrange 
            var addressBooks = AddressBookData.GetAddressBooks();

            // Act 
            JsonHelper<AddressBook>.CreateFile(addressBooks);
            new AddressBookService().Delete(addressBooks.First().FristName);
            var deletedAddressBooks = JsonHelper<AddressBook>.GetFiles();

            // Assert        
            Assert.True(deletedAddressBooks?.Count() == 1);

        }
    }
}