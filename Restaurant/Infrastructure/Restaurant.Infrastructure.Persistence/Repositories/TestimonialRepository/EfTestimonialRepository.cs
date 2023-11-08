using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Context;
using Restaurant.Infrastructure.Persistence.Repositories.TestimonialRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infrastructure.Persistence.Repositories.TestimonialRepository
{
    public class EfTestimonialRepository : GenericRepository<Testimonial>, ITestimonialRepository
    {
        public EfTestimonialRepository(RestaurantDbContext context) : base(context)
        {
        }
    }
}
