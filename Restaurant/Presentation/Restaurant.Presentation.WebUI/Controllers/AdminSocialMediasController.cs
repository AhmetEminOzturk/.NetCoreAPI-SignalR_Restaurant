using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Application.Dtos.SocialMedia.Requests;
using Restaurant.Core.Application.Dtos.SocialMedia;
using Restaurant.Presentation.WebUI.Services;

namespace Restaurant.Presentation.WebUI.Controllers
{
	public class AdminSocialMediasController : Controller
	{
		private readonly SocialMediaApiService _socialMediaApiService;

		public AdminSocialMediasController(SocialMediaApiService socialMediaApiService)
		{
			_socialMediaApiService = socialMediaApiService;
		}

		public async Task<IActionResult> Index()
		{
			return View(await _socialMediaApiService.GetAllAsync());
		}
		[HttpGet]
		public async Task<IActionResult> Create()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(CreateSocialMediaRequest createSocialMediaRequest)
		{
			if (ModelState.IsValid)
			{
				await _socialMediaApiService.CreateAsync(createSocialMediaRequest);
				return RedirectToAction(nameof(Index));
			}
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> Update(int id)
		{
			return View(await _socialMediaApiService.GetByIdAsync(id));
		}
		[HttpPost]
		public async Task<IActionResult> Update(GenericSocialMediaDto genericSocialMediaDto)
		{
			if (ModelState.IsValid)
			{
				await _socialMediaApiService.UpdateAsync(genericSocialMediaDto);
				return RedirectToAction(nameof(Index));
			}
			return View();
		}
		public async Task<IActionResult> Delete(int id)
		{
			await _socialMediaApiService.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
