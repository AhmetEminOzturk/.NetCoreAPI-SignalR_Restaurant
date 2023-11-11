using Restaurant.Core.Application.Dtos.About.Requests;
using Restaurant.Core.Application.Dtos.About;

namespace Restaurant.Presentation.WebUI.Services
{
	public class AboutApiService
	{
		private readonly HttpClient _httpClient;

		public AboutApiService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<List<GenericAboutDto>> GetAllAsync()
		{
			var response = await _httpClient.GetFromJsonAsync<List<GenericAboutDto>>("abouts");
			return response;
		}
		public async Task<GenericAboutDto> GetByIdAsync(int id)
		{
			var response = await _httpClient.GetFromJsonAsync<GenericAboutDto>($"abouts/{id}");
			return response;
		}
		public async Task CreateAsync(CreateAboutRequest createAboutRequest)
		{
			await _httpClient.PostAsJsonAsync("abouts", createAboutRequest);
		}
		public async Task UpdateAsync(GenericAboutDto genericAboutDto)
		{
			await _httpClient.PutAsJsonAsync("abouts", genericAboutDto);
		}
		public async Task DeleteAsync(int id)
		{
			await _httpClient.DeleteAsync($"abouts/{id}");
		}
	}
}
