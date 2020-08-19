using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskScheduler.MVC4.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult TaskScheduler()
		{
			ViewBag.Message = "Task Scheduler";

			return View();
		}
	}
}