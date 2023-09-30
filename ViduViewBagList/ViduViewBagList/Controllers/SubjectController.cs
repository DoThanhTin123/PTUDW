using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViduViewBagList.Models;

namespace ViduViewBagList.Controllers
{
    public class SubjectController : Controller
    {
        // GET: Subject
        public ActionResult List()
        {
            var model = new List<SubjectModel>()
            { 
                new SubjectModel ("SOT331", "Object Oriented Programming", 3),
                new SubjectModel("SOT355","Web Programming",3),
                new SubjectModel("SOT320","Program Technique",3),
                new SubjectModel("SOT382","General Informatic",2)    
            };
            return View(model);
        }
    }
}