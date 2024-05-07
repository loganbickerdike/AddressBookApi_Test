using AddressBookApi.Models;
using AddressBookApi.Services;
using AddressBookApi_Test.Data;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AddressBookApi_Test.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AddressBookController : ControllerBase
    {
        private readonly IAddressBookService _addressBookService;
        private readonly IMapper _mapper;

        public AddressBookController(IAddressBookService addressBookService, IMapper mapper)
        {
            _addressBookService = addressBookService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<AddressBookDto> GetAddressBook()
        {
            var addressBook = _addressBookService.Get();

            if (addressBook.Count() == 0)
                return NotFound();

            return Ok(_mapper.Map<IEnumerable<AddressBookDto>>(addressBook));
        }


        [HttpGet("{name}")]
        public ActionResult<AddressBookDto> GetAddressBook(string name)
        {
            var addressBook = _addressBookService.Get(name);

            if (String.IsNullOrEmpty(addressBook.FristName))
                return NotFound();

            return Ok(_mapper.Map<AddressBookDto>(addressBook));
        }


        [HttpPut]
        public ActionResult UpdateAddressBook(AddressBookDto adressBookDto)
        {
            if (_addressBookService.Update(_mapper.Map<AddressBook>(adressBookDto)))
                return Ok();
            else
                return NotFound();

        }

        [HttpDelete("{name}")]
        public ActionResult DeleteAddressBook(string name)
        {
            if (_addressBookService.Delete(name))
                return Ok();
            else
                return NotFound();

        }

    }
}
