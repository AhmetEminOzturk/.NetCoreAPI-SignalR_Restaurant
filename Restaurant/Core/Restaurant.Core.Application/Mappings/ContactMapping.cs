using AutoMapper;
using Restaurant.Core.Application.Dtos.Contact.Requests;
using Restaurant.Core.Application.Dtos.Contact.Responses;
using Restaurant.Core.Application.Dtos.Contact;
using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Mappings
{
    public class ContactMapping : Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact, GenericContactDto>().ReverseMap();
            CreateMap<Contact, CreateContactRequest>().ReverseMap();
            CreateMap<Contact, UpdateContactRequest>().ReverseMap();
            CreateMap<Contact, DisplayContactResponse>().ReverseMap();
            CreateMap<Contact, GetContactResponse>().ReverseMap();
        }
    }
}
