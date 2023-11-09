using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Application.Dtos.Booking.Requests;
using Restaurant.Core.Application.Dtos.Booking;
using Restaurant.Core.Application.Services.BookingService;

namespace Restaurant.Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingsController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var values = _bookingService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value = _bookingService.TGetByID(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult Create(CreateBookingRequest createBookingRequest)
        {
            _bookingService.TAdd(createBookingRequest);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(GenericBookingDto genericBookingDto)
        {
            _bookingService.TUpdate(genericBookingDto);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _bookingService.TDelete(id);
            return Ok();
        }
    }
}
