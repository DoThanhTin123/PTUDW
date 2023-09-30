using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Hello()
        {
            ViewBag.Greeting = "Chao tat cac cac em lop";
            ViewData["class"] = "63.CNTT-4,5";
            return View();
        }
    }
}