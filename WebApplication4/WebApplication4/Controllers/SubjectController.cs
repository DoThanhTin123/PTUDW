using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class SubjectController : Controller
    {
        // GET: Subject
        public ActionResult ViewBagObj()
        {
            SubjectModel sub = new SubjectModel("SOT320", "Program Technique", 3);
            ViewBag.Subject = sub;
            return View();
        }
    }
}