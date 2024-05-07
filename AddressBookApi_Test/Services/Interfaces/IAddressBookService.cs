using AddressBookApi.Models;

namespace AddressBookApi.Services
{
    public interface IAddressBookService
    {
        IEnumerable<AddressBook> Get();
        AddressBook Get(string name);
        bool Create(AddressBook address);
        bool Update(AddressBook address);   
        bool Delete(AddressBook address);
    }
}
