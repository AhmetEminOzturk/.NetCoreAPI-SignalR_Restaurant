using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Context;
using Restaurant.Infrastructure.Persistence.Repositories.ProductRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infrastructure.Persistence.Repositories.ProductRepository
{
    public class EfProductRepository : GenericRepository<Product>, IProductRepository
    {
        public EfProductRepository(RestaurantDbContext context) : base(context)
        {
        }
    }
}
