using COM.ZUOMANE.Portal.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COM.ZUOMANE.Portal.Controllers
{
	public class HomeController : Controller
	{
		[ResultFillter]
		[ActionFillter]
		[ExceptionFillter]
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}