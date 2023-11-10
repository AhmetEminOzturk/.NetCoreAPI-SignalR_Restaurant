using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Presentation.WebUI.Controllers
{
    public class AdminCategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
