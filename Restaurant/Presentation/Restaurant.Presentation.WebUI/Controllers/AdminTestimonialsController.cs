using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Application.Dtos.Testimonial.Requests;
using Restaurant.Core.Application.Dtos.Testimonial;
using Restaurant.Presentation.WebUI.Services;

namespace Restaurant.Presentation.WebUI.Controllers
{
	public class AdminTestimonialsController : Controller
	{
		private readonly TestimonialApiService _testimonialApiService;

		public AdminTestimonialsController(TestimonialApiService testimonialApiService)
		{
			_testimonialApiService = testimonialApiService;
		}

		public async Task<IActionResult> Index()
		{
			return View(await _testimonialApiService.GetAllAsync());
		}
		[HttpGet]
		public async Task<IActionResult> Create()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(CreateTestimonialRequest createTestimonialRequest)
		{
			if (ModelState.IsValid)
			{
				await _testimonialApiService.CreateAsync(createTestimonialRequest);
				return RedirectToAction(nameof(Index));
			}
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> Update(int id)
		{
			return View(await _testimonialApiService.GetByIdAsync(id));
		}
		[HttpPost]
		public async Task<IActionResult> Update(GenericTestimonialDto genericTestimonialDto)
		{
			if (ModelState.IsValid)
			{
				await _testimonialApiService.UpdateAsync(genericTestimonialDto);
				return RedirectToAction(nameof(Index));
			}
			return View();
		}
		public async Task<IActionResult> Delete(int id)
		{
			await _testimonialApiService.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
