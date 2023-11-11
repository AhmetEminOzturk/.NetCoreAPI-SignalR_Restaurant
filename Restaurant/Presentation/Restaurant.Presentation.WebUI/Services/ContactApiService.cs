using Restaurant.Core.Application.Dtos.Contact.Requests;
using Restaurant.Core.Application.Dtos.Contact;

namespace Restaurant.Presentation.WebUI.Services
{
	public class ContactApiService
	{
		private readonly HttpClient _httpClient;

		public ContactApiService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<List<GenericContactDto>> GetAllAsync()
		{
			var response = await _httpClient.GetFromJsonAsync<List<GenericContactDto>>("contacts");
			return response;
		}
		public async Task<GenericContactDto> GetByIdAsync(int id)
		{
			var response = await _httpClient.GetFromJsonAsync<GenericContactDto>($"contacts/{id}");
			return response;
		}
		public async Task CreateAsync(CreateContactRequest createContactRequest)
		{
			await _httpClient.PostAsJsonAsync("contacts", createContactRequest);
		}
		public async Task UpdateAsync(GenericContactDto genericContactDto)
		{
			await _httpClient.PutAsJsonAsync("contacts", genericContactDto);
		}
		public async Task DeleteAsync(int id)
		{
			await _httpClient.DeleteAsync($"contacts/{id}");
		}
	}
}
