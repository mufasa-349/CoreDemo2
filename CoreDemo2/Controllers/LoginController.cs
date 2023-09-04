using Microsoft.AspNetCore.Mvc;

namespace CoreDemo2.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
