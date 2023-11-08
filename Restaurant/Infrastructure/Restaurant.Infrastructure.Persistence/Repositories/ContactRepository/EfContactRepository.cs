using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Context;
using Restaurant.Infrastructure.Persistence.Repositories.ContactRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infrastructure.Persistence.Repositories.ContactRepository
{
    public class EfContactRepository : GenericRepository<Contact>, IContactRepository
    {
        public EfContactRepository(RestaurantDbContext context) : base(context)
        {
        }
    }
}
