using Restaurant.Core.Application.Dtos.Discount.Requests;
using Restaurant.Core.Application.Dtos.Discount;

namespace Restaurant.Presentation.WebUI.Services
{
	public class DiscountApiService
	{
		private readonly HttpClient _httpClient;

		public DiscountApiService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<List<GenericDiscountDto>> GetAllAsync()
		{
			var response = await _httpClient.GetFromJsonAsync<List<GenericDiscountDto>>("discounts");
			return response;
		}
		public async Task<GenericDiscountDto> GetByIdAsync(int id)
		{
			var response = await _httpClient.GetFromJsonAsync<GenericDiscountDto>($"discounts/{id}");
			return response;
		}
		public async Task CreateAsync(CreateDiscountRequest createDiscountRequest)
		{
			await _httpClient.PostAsJsonAsync("discounts", createDiscountRequest);
		}
		public async Task UpdateAsync(GenericDiscountDto genericDiscountDto)
		{
			await _httpClient.PutAsJsonAsync("discounts", genericDiscountDto);
		}
		public async Task DeleteAsync(int id)
		{
			await _httpClient.DeleteAsync($"discounts/{id}");
		}

	}
}
