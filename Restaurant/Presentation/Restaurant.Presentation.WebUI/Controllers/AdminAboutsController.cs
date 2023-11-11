using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Application.Dtos.About.Requests;
using Restaurant.Core.Application.Dtos.About;
using Restaurant.Presentation.WebUI.Services;

namespace Restaurant.Presentation.WebUI.Controllers
{
	public class AdminAboutsController : Controller
	{
		private readonly AboutApiService _aboutApiService;

		public AdminAboutsController(AboutApiService aboutApiService)
		{
			_aboutApiService = aboutApiService;
		}

		public async Task<IActionResult> Index()
		{
			return View(await _aboutApiService.GetAllAsync());
		}
		[HttpGet]
		public async Task<IActionResult> Create()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(CreateAboutRequest createAboutRequest)
		{
			if (ModelState.IsValid)
			{
				await _aboutApiService.CreateAsync(createAboutRequest);
				return RedirectToAction(nameof(Index));
			}
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> Update(int id)
		{
			return View(await _aboutApiService.GetByIdAsync(id));
		}
		[HttpPost]
		public async Task<IActionResult> Update(GenericAboutDto genericAboutDto)
		{
			if (ModelState.IsValid)
			{
				await _aboutApiService.UpdateAsync(genericAboutDto);
				return RedirectToAction(nameof(Index));
			}
			return View();
		}
		public async Task<IActionResult> Delete(int id)
		{
			await _aboutApiService.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
