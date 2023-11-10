using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Presentation.WebUI.Controllers
{
    public class AdminLayoutsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
