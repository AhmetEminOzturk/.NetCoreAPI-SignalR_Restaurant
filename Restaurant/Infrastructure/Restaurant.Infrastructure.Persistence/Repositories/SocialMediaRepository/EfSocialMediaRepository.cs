using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infrastructure.Persistence.Repositories.SocialMediaRepository
{
    public class EfSocialMediaRepository : GenericRepository<SocialMedia>, ISocialMediaRepository
    {
        public EfSocialMediaRepository(RestaurantDbContext context) : base(context)
        {
        }
    }
}
