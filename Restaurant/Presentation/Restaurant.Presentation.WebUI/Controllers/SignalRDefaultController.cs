using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Presentation.WebUI.Controllers
{
	public class SignalRDefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
