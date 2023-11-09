using AutoMapper;
using Restaurant.Core.Application.Dtos.Contact.Requests;
using Restaurant.Core.Application.Dtos.Contact;
using Restaurant.Core.Application.Services.ContactService;
using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Repositories;
using Restaurant.Infrastructure.Persistence.Repositories.ContactRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.ContactService
{
    public class ContactService : GenericService<Contact, GenericContactDto>, IContactService
    {
        private readonly IContactRepository _contactRepository;
        public ContactService(IGenericRepository<Contact> repository, IMapper mapper, IContactRepository contactRepository) : base(repository, mapper)
        {
            _contactRepository = contactRepository;
        }

        public void TAdd(CreateContactRequest createContactRequest)
        {
            var newEntity = _mapper.Map<Contact>(createContactRequest);
            _contactRepository.Add(newEntity);
            
        }
    }
}

