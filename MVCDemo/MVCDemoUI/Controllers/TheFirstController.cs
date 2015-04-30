using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemoUI.Controllers.TheFirst
{
    public class TheFirstController : Controller
    {
        // GET: TheFirst
        public ActionResult Index()
        {
            return View();
        }

        // GET: TheFirst/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TheFirst/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TheFirst/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TheFirst/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TheFirst/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TheFirst/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TheFirst/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
