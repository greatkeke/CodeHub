using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemoUI.Controllers.PostNew
{
    public class PostNewsController : Controller
    {
        // GET: PostNews
        public ActionResult Index()
        {
            List<News> listNews = new List<News>(){
                new News{ID=Guid.NewGuid(),Title="你好~世界",AutherId=Guid.NewGuid(),PortDate=DateTime.Now,Content="世界是什么样的？你有没有考虑过？"}
            };
            ViewData.Model = listNews;
            return View();
        }

        // GET: PostNews/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PostNews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostNews/Create
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

        // GET: PostNews/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PostNews/Edit/5
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

        // GET: PostNews/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PostNews/Delete/5
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
