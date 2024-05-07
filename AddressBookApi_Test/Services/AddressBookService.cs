using AddressBookApi.Helpers;
using AddressBookApi.Models;
using System.Net;
using System.Text.Json;
using System.Xml.Linq;
namespace AddressBookApi.Services
{
    public class AddressBookService : IAddressBookService
    {
        public bool Create(AddressBook address)
        {
            try
            {
                JsonHelper<AddressBook>.CreateFile(address);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public IEnumerable<AddressBook> Get()
        {
            try
            {
                return JsonHelper<AddressBook>.GetFiles();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public AddressBook Get(string name)
        {
            var addressBooks = JsonHelper<AddressBook>.GetFiles();
            return addressBooks.Where(x => x.FristName == name).FirstOrDefault() ?? new AddressBook();
        }

        public bool Update(AddressBook updatedAddress)
        {
            try
            {
                var addressBooks = JsonHelper<AddressBook>.GetFiles().ToList();
                var address =  addressBooks.Where(x => x.FristName == updatedAddress.FristName).FirstOrDefault();

                if (address != null)
                {
                    addressBooks.Remove(address);
                    addressBooks.Add(updatedAddress);
                    JsonHelper<List<AddressBook>>.CreateFile(addressBooks);
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(AddressBook address)
        {
            try
            {
                var addressBooks = JsonHelper<AddressBook>.GetFiles().ToList();
                addressBooks.Remove(addressBooks.Where(x => x.FristName == address.FristName).First());
                JsonHelper<List<AddressBook>>.CreateFile(addressBooks);

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
