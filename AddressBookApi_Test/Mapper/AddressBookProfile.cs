using AddressBookApi.Models;
using AutoMapper;
using System.Security.Claims;

namespace AddressBookApi_Test.Mapper
{
    public class AddressBookProfile : Profile
    {
        public AddressBookProfile()
        {
            CreateMap<AddressBook, AddressBookDto>();
            CreateMap<AddressBookDto, AddressBook>();
        }
    }
}
