using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyClass.DAO;
using MyClass.Model;

namespace _63CNTT4.Areas.Admin.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesDAO categoriesDAO = new CategoriesDAO();

        /// ///////////////////////////////////////////////////
        //INDEX
        // GET: Admin/Categories/Index
        public ActionResult Index()
        {
            return View(categoriesDAO.getList("Index"));
        }

        ///// ///////////////////////////////////////////////////
        ////DETAILS
        //// GET: Admin/Categories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categories categories = categoriesDAO.getRow(id);
            if (categories == null)
            {
                return HttpNotFound();
            }
            return View(categories);
        }


        ///// ///////////////////////////////////////////////////
        ////CREATE
        //// GET: Admin/Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categories categories)
        {
            if (ModelState.IsValid)
            {
                categoriesDAO.Insert(categories);
                return RedirectToAction("Index");
            }
            return View(categories);
        }


        /// ///////////////////////////////////////////////////
        //EDIT
        // GET: Admin/Categories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categories categories = categoriesDAO.getRow(id);
            if (categories == null)
            {
                return HttpNotFound();
            }
            return View(categories);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categories categories)
        {
            if (ModelState.IsValid)
            {
                categoriesDAO.Update(categories);
                return RedirectToAction("Index");
            }
            return View(categories);
        }


        /// ///////////////////////////////////////////////////
        //DELETE
        // GET: Admin/Categories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categories categories = categoriesDAO.getRow(id);
            if (categories == null)
            {
                return HttpNotFound();
            }
            return View(categories);
        }

        // POST: Admin/Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Categories categories = categoriesDAO.getRow(id);
            categoriesDAO.Delete(categories);

            return RedirectToAction("Index");
        }
    }
}
