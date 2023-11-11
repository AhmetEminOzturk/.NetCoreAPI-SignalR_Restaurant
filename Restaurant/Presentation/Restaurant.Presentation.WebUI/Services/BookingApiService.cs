using Restaurant.Core.Application.Dtos.Booking.Requests;
using Restaurant.Core.Application.Dtos.Booking;

namespace Restaurant.Presentation.WebUI.Services
{
	public class BookingApiService
	{
		private readonly HttpClient _httpClient;

		public BookingApiService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<List<GenericBookingDto>> GetAllAsync()
		{
			var response = await _httpClient.GetFromJsonAsync<List<GenericBookingDto>>("bookings");
			return response;
		}
		public async Task<GenericBookingDto> GetByIdAsync(int id)
		{
			var response = await _httpClient.GetFromJsonAsync<GenericBookingDto>($"bookings/{id}");
			return response;
		}
		public async Task CreateAsync(CreateBookingRequest createBookingRequest)
		{
			await _httpClient.PostAsJsonAsync("bookings", createBookingRequest);
		}
		public async Task UpdateAsync(GenericBookingDto genericBookingDto)
		{
			await _httpClient.PutAsJsonAsync("bookings", genericBookingDto);
		}
		public async Task DeleteAsync(int id)
		{
			await _httpClient.DeleteAsync($"bookings/{id}");
		}
	}
}
