using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Application.Dtos.Feature.Requests;
using Restaurant.Core.Application.Dtos.Feature;
using Restaurant.Presentation.WebUI.Services;

namespace Restaurant.Presentation.WebUI.Controllers
{
	public class AdminFeaturesController : Controller
	{
		private readonly FeatureApiService _featureApiService;

		public AdminFeaturesController(FeatureApiService featureApiService)
		{
			_featureApiService = featureApiService;
		}

		public async Task<IActionResult> Index()
		{
			return View(await _featureApiService.GetAllAsync());
		}
		[HttpGet]
		public async Task<IActionResult> Create()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(CreateFeatureRequest createFeatureRequest)
		{
			if (ModelState.IsValid)
			{
				await _featureApiService.CreateAsync(createFeatureRequest);
				return RedirectToAction(nameof(Index));
			}
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> Update(int id)
		{
			return View(await _featureApiService.GetByIdAsync(id));
		}
		[HttpPost]
		public async Task<IActionResult> Update(GenericFeatureDto genericFeatureDto)
		{
			if (ModelState.IsValid)
			{
				await _featureApiService.UpdateAsync(genericFeatureDto);
				return RedirectToAction(nameof(Index));
			}
			return View();
		}
		public async Task<IActionResult> Delete(int id)
		{
			await _featureApiService.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
