using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infrastructure.Persistence.Repositories.AboutRepository
{
    public class EfAboutRepository : GenericRepository<About>, IAboutRepository
    {
        public EfAboutRepository(RestaurantDbContext context) : base(context)
        {
        }
    }
}
