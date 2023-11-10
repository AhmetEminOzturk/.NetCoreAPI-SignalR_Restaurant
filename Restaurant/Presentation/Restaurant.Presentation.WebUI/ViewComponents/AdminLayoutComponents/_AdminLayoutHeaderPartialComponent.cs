using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Presentation.WebUI.ViewComponents.AdminLayoutComponents
{
    public class _AdminLayoutHeaderPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
