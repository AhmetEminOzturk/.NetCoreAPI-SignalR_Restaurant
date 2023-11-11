using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Application.Dtos.Booking.Requests;
using Restaurant.Core.Application.Dtos.Booking;
using Restaurant.Presentation.WebUI.Services;

namespace Restaurant.Presentation.WebUI.Controllers
{
	public class AdminBookingsController : Controller
	{
		private readonly BookingApiService _bookingApiService;

		public AdminBookingsController(BookingApiService bookingApiService)
		{
			_bookingApiService = bookingApiService;
		}

		public async Task<IActionResult> Index()
		{
			return View(await _bookingApiService.GetAllAsync());
		}
		[HttpGet]
		public async Task<IActionResult> Create()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(CreateBookingRequest createBookingRequest)
		{
			if (ModelState.IsValid)
			{
				await _bookingApiService.CreateAsync(createBookingRequest);
				return RedirectToAction(nameof(Index));
			}
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> Update(int id)
		{
			return View(await _bookingApiService.GetByIdAsync(id));
		}
		[HttpPost]
		public async Task<IActionResult> Update(GenericBookingDto genericBookingDto)
		{
			if (ModelState.IsValid)
			{
				await _bookingApiService.UpdateAsync(genericBookingDto);
				return RedirectToAction(nameof(Index));
			}
			return View();
		}
		public async Task<IActionResult> Delete(int id)
		{
			await _bookingApiService.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
