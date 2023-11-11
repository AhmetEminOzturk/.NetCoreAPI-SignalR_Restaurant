using Restaurant.Core.Application.Dtos.Feature.Requests;
using Restaurant.Core.Application.Dtos.Feature;

namespace Restaurant.Presentation.WebUI.Services
{
	public class FeatureApiService
	{
		private readonly HttpClient _httpClient;

		public FeatureApiService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<List<GenericFeatureDto>> GetAllAsync()
		{
			var response = await _httpClient.GetFromJsonAsync<List<GenericFeatureDto>>("features");
			return response;
		}
		public async Task<GenericFeatureDto> GetByIdAsync(int id)
		{
			var response = await _httpClient.GetFromJsonAsync<GenericFeatureDto>($"features/{id}");
			return response;
		}
		public async Task CreateAsync(CreateFeatureRequest createFeatureRequest)
		{
			await _httpClient.PostAsJsonAsync("features", createFeatureRequest);
		}
		public async Task UpdateAsync(GenericFeatureDto genericFeatureDto)
		{
			await _httpClient.PutAsJsonAsync("features", genericFeatureDto);
		}
		public async Task DeleteAsync(int id)
		{
			await _httpClient.DeleteAsync($"features/{id}");
		}
	}
}
