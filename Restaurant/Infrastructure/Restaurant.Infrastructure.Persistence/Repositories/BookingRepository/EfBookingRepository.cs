using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Context;
using Restaurant.Infrastructure.Persistence.Repositories.AboutRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infrastructure.Persistence.Repositories.BookingRepository
{
    public class EfBookingRepository : GenericRepository<Booking>, IBookingRepository
    {
        public EfBookingRepository(RestaurantDbContext context) : base(context)
        {
        }
    }
}
