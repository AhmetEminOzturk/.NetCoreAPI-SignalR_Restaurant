using Restaurant.Core.Application.Dtos.Product.Requests;
using Restaurant.Core.Application.Dtos.Product;
using Restaurant.Core.Application.Dtos.Product.Responses;

namespace Restaurant.Presentation.WebUI.Services
{
	public class ProductApiService
	{
		private readonly HttpClient _httpClient;

		public ProductApiService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<List<DisplayProductsWithCategoriesResponse>> GetProductsWithCategories()
		{
			var response = await _httpClient.GetFromJsonAsync<List<DisplayProductsWithCategoriesResponse>>("Products/GetProductsWithCategory");
			return response;
		}
		public async Task<GenericProductDto> GetByIdAsync(int id)
		{
			var response = await _httpClient.GetFromJsonAsync<GenericProductDto>($"Products/{id}");
			return response;
		}
		public async Task CreateAsync(CreateProductRequest createProductRequest)
		{
			createProductRequest.ProductStatus = true;
			await _httpClient.PostAsJsonAsync("Products", createProductRequest);
		}
		public async Task UpdateAsync(GenericProductDto genericProductDto)
		{
			await _httpClient.PutAsJsonAsync("Products", genericProductDto);
		}
		public async Task DeleteAsync(int id)
		{
			await _httpClient.DeleteAsync($"Products/{id}");
		}
	}
}
