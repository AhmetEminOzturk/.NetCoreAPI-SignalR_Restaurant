using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Application.Dtos.Discount.Requests;
using Restaurant.Core.Application.Dtos.Discount;
using Restaurant.Presentation.WebUI.Services;

namespace Restaurant.Presentation.WebUI.Controllers
{
	public class AdminDiscountsController : Controller
	{
		private readonly DiscountApiService _discountApiService;

		public AdminDiscountsController(DiscountApiService discountApiService)
		{
			_discountApiService = discountApiService;
		}

		public async Task<IActionResult> Index()
		{
			return View(await _discountApiService.GetAllAsync());
		}
		[HttpGet]
		public async Task<IActionResult> Create()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(CreateDiscountRequest createDiscountRequest)
		{
			if (ModelState.IsValid)
			{
				await _discountApiService.CreateAsync(createDiscountRequest);
				return RedirectToAction(nameof(Index));
			}
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> Update(int id)
		{
			return View(await _discountApiService.GetByIdAsync(id));
		}
		[HttpPost]
		public async Task<IActionResult> Update(GenericDiscountDto genericDiscountDto)
		{
			if (ModelState.IsValid)
			{
				await _discountApiService.UpdateAsync(genericDiscountDto);
				return RedirectToAction(nameof(Index));
			}
			return View();
		}
		public async Task<IActionResult> Delete(int id)
		{
			await _discountApiService.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
