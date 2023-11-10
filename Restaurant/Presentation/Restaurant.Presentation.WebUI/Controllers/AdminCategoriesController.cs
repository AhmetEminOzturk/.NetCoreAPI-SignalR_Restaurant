using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Application.Dtos.Category;
using Restaurant.Core.Application.Dtos.Category.Requests;
using Restaurant.Presentation.WebUI.Services;

namespace Restaurant.Presentation.WebUI.Controllers
{
    public class AdminCategoriesController : Controller
    {
        private readonly CategoryApiService _categoryApiService;

        public AdminCategoriesController(CategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }

        public async Task<IActionResult> Index()
        {
            return View( await _categoryApiService.GetAllAsync());
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
		[HttpPost]
		public async Task<IActionResult> Create(CreateCategoryRequest createCategoryRequest)
		{
            if (ModelState.IsValid)
            {
				await _categoryApiService.CreateAsync(createCategoryRequest);
				return RedirectToAction(nameof(Index));
			}
            return View();
		}
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            return View(await _categoryApiService.GetByIdAsync(id));
        }
        [HttpPost]
		public async Task<IActionResult> Update(GenericCategoryDto genericCategoryDto)
		{
			if (ModelState.IsValid)
            {
                await _categoryApiService.UpdateAsync(genericCategoryDto);
                return RedirectToAction(nameof(Index));
            }
            return View();
		}
		public async Task<IActionResult> Delete(int id)
		{
			await _categoryApiService.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
