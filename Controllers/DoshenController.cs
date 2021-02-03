using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    public class DoshenController : Controller
    {
        // GET: Doshen
        public ActionResult Index()
        {

            ViewBag.DisplayText = "Welcome to Doshen Traffic Management System";
            return View();
        }

        [HttpPost]
        public ActionResult Goto(string gotoUrl)
        {

            return Redirect(gotoUrl);
        }
    }
}