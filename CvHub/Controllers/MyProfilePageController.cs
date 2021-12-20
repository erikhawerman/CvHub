using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CvHub.Controllers
{
    public class MyProfilePageController : Controller
    {
        // GET: MyProfilePage
        public ActionResult Index()
        {
            return View();
        }

        // GET: MyProfilePage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MyProfilePage/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: MyProfilePage/Create
        [HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: MyProfilePage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MyProfilePage/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("MyProfilePage");
            }
            catch
            {
                return View();
            }
        }

        // GET: MyProfilePage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MyProfilePage/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("MyProfilePage");
            }
            catch
            {
                return View();
            }
        }
    }
}
