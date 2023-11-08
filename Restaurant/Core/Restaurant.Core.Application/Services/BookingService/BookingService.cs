using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Repositories.BookingRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.BookingService
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public void TAdd(Booking entity)
        {
            _bookingRepository.Add(entity);
        }

        public void TDelete(Booking entity)
        {
            _bookingRepository.Delete(entity);
        }

        public Booking TGetByID(int id)
        {
            return _bookingRepository.GetByID(id);
        }

        public List<Booking> TGetListAll()
        {
            return _bookingRepository.GetListAll();
        }

        public void TUpdate(Booking entity)
        {
            _bookingRepository.Update(entity);
        }
    }
}
