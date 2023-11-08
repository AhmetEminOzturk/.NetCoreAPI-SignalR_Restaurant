using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Context;
using Restaurant.Infrastructure.Persistence.Repositories.DiscountRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infrastructure.Persistence.Repositories.DiscountRepository
{
    public class EfDiscountRepository : GenericRepository<Discount>, IDiscountRepository
    {
        public EfDiscountRepository(RestaurantDbContext context) : base(context)
        {
        }
    }
}
