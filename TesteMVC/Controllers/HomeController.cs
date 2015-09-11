using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace TesteMVC.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			var mvcName = typeof(Controller).Assembly.GetName ();
			var isMono = Type.GetType ("Mono.Runtime") != null;

			ViewData ["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData ["Runtime"] = isMono ? "Mono" : ".NET";

			return View ();
		}

		public JsonResult Lista()
		{
			var lista = new List<int> ();

			for (int i = 0; i < 50; i++) {
				lista.Add (i);
			}

			var tes = lista.TakeWhile(a => a < 15).LastOrDefault();

			return Json(tes, JsonRequestBehavior.AllowGet);
		}
	}
}