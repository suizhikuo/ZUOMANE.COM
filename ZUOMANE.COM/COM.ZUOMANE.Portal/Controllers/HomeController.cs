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
			ViewBag.Message = "关于我们";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "联系我们";

			return View();
		}
	}
}