using System.Text.Json;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using webapp_net8_fox.Models;

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

		[HttpPost]
		public ActionResult Contact(ContactModel model)
		{
			if(ModelState.IsValid)
			{
				//
			}

			return RedirectToAction(nameof(ContactResult), model);
		}

		[HttpGet]
		public ActionResult ContactResult(ContactModel model) => View(model);
	}
}
