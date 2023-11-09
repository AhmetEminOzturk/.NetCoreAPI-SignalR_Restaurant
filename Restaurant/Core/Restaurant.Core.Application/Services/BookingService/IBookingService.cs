using Restaurant.Core.Application.Dtos.Booking;
using Restaurant.Core.Application.Dtos.Booking.Requests;
using Restaurant.Core.Application.Dtos.Testimonial.Requests;
using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.BookingService
{
    public interface IBookingService : IGenericService<Booking ,GenericBookingDto>
    {
        void TAdd(CreateBookingRequest createBookingRequest);
    }
}
