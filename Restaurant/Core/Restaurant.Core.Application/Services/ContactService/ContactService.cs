using Restaurant.Core.Application.Services.ContactService;
using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Repositories.ContactRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.ContactService
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public void TAdd(Contact entity)
        {
            _contactRepository.Add(entity);
        }

        public void TDelete(Contact entity)
        {
            _contactRepository.Delete(entity);
        }

        public Contact TGetByID(int id)
        {
            return _contactRepository.GetByID(id);
        }

        public List<Contact> TGetListAll()
        {
            return _contactRepository.GetListAll();
        }

        public void TUpdate(Contact entity)
        {
            _contactRepository.Update(entity);
        }
    }
}
