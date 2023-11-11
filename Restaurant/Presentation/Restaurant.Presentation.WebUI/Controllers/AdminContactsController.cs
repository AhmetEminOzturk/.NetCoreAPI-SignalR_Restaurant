using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Application.Dtos.Contact.Requests;
using Restaurant.Core.Application.Dtos.Contact;
using Restaurant.Presentation.WebUI.Services;

namespace Restaurant.Presentation.WebUI.Controllers
{
	public class AdminContactsController : Controller
	{
		private readonly ContactApiService _contactApiService;

		public AdminContactsController(ContactApiService contactApiService)
		{
			_contactApiService = contactApiService;
		}

		public async Task<IActionResult> Index()
		{
			return View(await _contactApiService.GetAllAsync());
		}
		[HttpGet]
		public async Task<IActionResult> Create()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(CreateContactRequest createContactRequest)
		{
			if (ModelState.IsValid)
			{
				await _contactApiService.CreateAsync(createContactRequest);
				return RedirectToAction(nameof(Index));
			}
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> Update(int id)
		{
			return View(await _contactApiService.GetByIdAsync(id));
		}
		[HttpPost]
		public async Task<IActionResult> Update(GenericContactDto genericContactDto)
		{
			if (ModelState.IsValid)
			{
				await _contactApiService.UpdateAsync(genericContactDto);
				return RedirectToAction(nameof(Index));
			}
			return View();
		}
		public async Task<IActionResult> Delete(int id)
		{
			await _contactApiService.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
