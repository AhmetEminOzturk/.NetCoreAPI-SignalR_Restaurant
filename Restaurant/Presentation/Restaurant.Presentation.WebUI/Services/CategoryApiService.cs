using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Application.Dtos.Category;
using Restaurant.Core.Application.Dtos.Category.Requests;

namespace Restaurant.Presentation.WebUI.Services
{
    public class CategoryApiService
    {
        private readonly HttpClient _httpClient;

        public CategoryApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<GenericCategoryDto>> GetAllAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<GenericCategoryDto>>("categories");
            return response;
        }
        public async Task<GenericCategoryDto> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<GenericCategoryDto>($"categories/{id}");
            return response;
        }
		public async Task CreateAsync(CreateCategoryRequest createCategoryRequest)
        {
			createCategoryRequest.Status = true;
			await _httpClient.PostAsJsonAsync("categories", createCategoryRequest);
        }
		public async Task UpdateAsync(GenericCategoryDto genericCategoryDto)
        {
            await _httpClient.PutAsJsonAsync("categories", genericCategoryDto);
        }
		public async Task DeleteAsync(int id)
		{
            await _httpClient.DeleteAsync($"categories/{id}");
		}

	}
}
