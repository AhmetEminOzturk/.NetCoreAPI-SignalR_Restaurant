using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Context;
using Restaurant.Infrastructure.Persistence.Repositories.CategoryRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infrastructure.Persistence.Repositories.CategoryRepository
{
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public EfCategoryRepository(RestaurantDbContext context) : base(context)
        {
        }
    }
}
