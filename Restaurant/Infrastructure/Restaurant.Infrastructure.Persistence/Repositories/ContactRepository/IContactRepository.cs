using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infrastructure.Persistence.Repositories.ContactRepository
{
    public interface IContactRepository : IGenericRepository<Contact>
    {
    }
}
