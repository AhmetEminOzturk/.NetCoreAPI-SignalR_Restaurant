using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Context;
using Restaurant.Infrastructure.Persistence.Repositories.FeatureRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infrastructure.Persistence.Repositories.FeatureRepository
{
    public class EfFeatureRepository : GenericRepository<Feature>, IFeatureRepository
    {
        public EfFeatureRepository(RestaurantDbContext context) : base(context)
        {
        }
    }
}
