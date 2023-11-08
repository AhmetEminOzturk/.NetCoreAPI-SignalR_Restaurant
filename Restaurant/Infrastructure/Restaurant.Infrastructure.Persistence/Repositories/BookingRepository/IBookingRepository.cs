using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infrastructure.Persistence.Repositories.BookingRepository
{
    public interface IBookingRepository : IGenericRepository<Booking>
    {
    }
}
