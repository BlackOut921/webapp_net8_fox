using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace webapp_net8_fox.Controllers
{
	[AllowAnonymous]
	public class HomeController : Controller
	{
		[HttpGet]
		public IActionResult Index() => View();

		[HttpGet]
		public IActionResult About() => View();

		[HttpGet]
		public IActionResult Contact() => View();
	}
}
