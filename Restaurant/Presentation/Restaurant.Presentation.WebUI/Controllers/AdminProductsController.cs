using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Application.Dtos.Product.Requests;
using Restaurant.Core.Application.Dtos.Product;
using Restaurant.Presentation.WebUI.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Restaurant.Presentation.WebUI.Controllers
{
	public class AdminProductsController : Controller
	{
		private readonly ProductApiService _productApiService;
		private readonly CategoryApiService _categoryApiService;

		public AdminProductsController(ProductApiService productApiService, CategoryApiService categoryApiService)
		{
			_productApiService = productApiService;
			_categoryApiService = categoryApiService;
		}

		public async Task<IActionResult> Index()
		{
			return View(await _productApiService.GetProductsWithCategories());
		}
		[HttpGet]
		public async Task<IActionResult> Create()
		{
			var categoriesDto = await _categoryApiService.GetAllAsync();

			ViewBag.categories = new SelectList(categoriesDto, "Id", "Name");
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(CreateProductRequest createProductRequest)
		{
			if (ModelState.IsValid)
			{
				await _productApiService.CreateAsync(createProductRequest);
				return RedirectToAction(nameof(Index));
			}

			var categoriesDto = await _categoryApiService.GetAllAsync();
			ViewBag.categories = new SelectList(categoriesDto, "Id", "Name");
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> Update(int id)
		{
			var product = await _productApiService.GetByIdAsync(id);
			var categoriesDto = await _categoryApiService.GetAllAsync();
			ViewBag.categories = new SelectList(categoriesDto, "Id", "Name", product.CategoryId);
			return View(await _productApiService.GetByIdAsync(id));
		}
		[HttpPost]
		public async Task<IActionResult> Update(GenericProductDto genericProductDto)
		{
			if (ModelState.IsValid)
			{
				await _productApiService.UpdateAsync(genericProductDto);
				return RedirectToAction(nameof(Index));
			}
			var categoriesDto = await _categoryApiService.GetAllAsync();
			ViewBag.categories = new SelectList(categoriesDto, "Id", "Name", genericProductDto.CategoryId);
			return View();
		}
		public async Task<IActionResult> Delete(int id)
		{
			await _productApiService.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
