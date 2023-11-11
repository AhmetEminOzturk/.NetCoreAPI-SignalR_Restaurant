using Restaurant.Core.Application.Dtos.Testimonial.Requests;
using Restaurant.Core.Application.Dtos.Testimonial;

namespace Restaurant.Presentation.WebUI.Services
{
	public class TestimonialApiService
	{
		private readonly HttpClient _httpClient;

		public TestimonialApiService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<List<GenericTestimonialDto>> GetAllAsync()
		{
			var response = await _httpClient.GetFromJsonAsync<List<GenericTestimonialDto>>("testimonials");
			return response;
		}
		public async Task<GenericTestimonialDto> GetByIdAsync(int id)
		{
			var response = await _httpClient.GetFromJsonAsync<GenericTestimonialDto>($"testimonials/{id}");
			return response;
		}
		public async Task CreateAsync(CreateTestimonialRequest createTestimonialRequest)
		{
			createTestimonialRequest.Status = true;
			await _httpClient.PostAsJsonAsync("testimonials", createTestimonialRequest);
		}
		public async Task UpdateAsync(GenericTestimonialDto genericTestimonialDto)
		{
			await _httpClient.PutAsJsonAsync("testimonials", genericTestimonialDto);
		}
		public async Task DeleteAsync(int id)
		{
			await _httpClient.DeleteAsync($"testimonials/{id}");
		}
	}
}
