using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Presentation.WebUI.ViewComponents.AdminLayoutComponents
{
	public class _AdminLayoutFooterPartialComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
