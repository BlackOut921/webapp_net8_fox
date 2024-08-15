using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace webapp_net8_fox.Controllers
{
	[AllowAnonymous]
	public class HomeController : Controller
	{
		//IActionResult=multiple ActionResult return types are possible in an action

		[HttpGet]
		public ActionResult Index() => View();

		[HttpGet]
		public ActionResult About() => View();

		[HttpGet]
		public ActionResult Contact() => View();
	}
}
