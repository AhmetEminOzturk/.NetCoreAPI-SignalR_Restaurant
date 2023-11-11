using Restaurant.Core.Application.Dtos.SocialMedia.Requests;
using Restaurant.Core.Application.Dtos.SocialMedia;

namespace Restaurant.Presentation.WebUI.Services
{
	public class SocialMediaApiService
	{
		private readonly HttpClient _httpClient;

		public SocialMediaApiService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<List<GenericSocialMediaDto>> GetAllAsync()
		{
			var response = await _httpClient.GetFromJsonAsync<List<GenericSocialMediaDto>>("SocialMedias");
			return response;
		}
		public async Task<GenericSocialMediaDto> GetByIdAsync(int id)
		{
			var response = await _httpClient.GetFromJsonAsync<GenericSocialMediaDto>($"SocialMedias/{id}");
			return response;
		}
		public async Task CreateAsync(CreateSocialMediaRequest createSocialMediaRequest)
		{
			await _httpClient.PostAsJsonAsync("SocialMedias", createSocialMediaRequest);
		}
		public async Task UpdateAsync(GenericSocialMediaDto genericSocialMediaDto)
		{
			await _httpClient.PutAsJsonAsync("SocialMedias", genericSocialMediaDto);
		}
		public async Task DeleteAsync(int id)
		{
			await _httpClient.DeleteAsync($"SocialMedias/{id}");
		}
	}
}
