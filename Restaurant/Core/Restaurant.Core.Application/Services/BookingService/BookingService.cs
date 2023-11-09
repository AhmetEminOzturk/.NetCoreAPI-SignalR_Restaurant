using AutoMapper;
using Restaurant.Core.Application.Dtos.Booking.Requests;
using Restaurant.Core.Application.Dtos.Booking;
using Restaurant.Core.Application.Services.BookingService;
using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Repositories;
using Restaurant.Infrastructure.Persistence.Repositories.BookingRepository;
using Restaurant.Infrastructure.Persistence.Repositories.BookingRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.BookingService
{
    public class BookingService : GenericService<Booking, GenericBookingDto>, IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        public BookingService(IGenericRepository<Booking> repository, IMapper mapper, IBookingRepository bookingRepository) : base(repository, mapper)
        {
            _bookingRepository = bookingRepository;
        }

        public void TAdd(CreateBookingRequest createBookingRequest)
        {
            var newEntity = _mapper.Map<Booking>(createBookingRequest);
            _bookingRepository.Add(newEntity);
        }
    }
}
