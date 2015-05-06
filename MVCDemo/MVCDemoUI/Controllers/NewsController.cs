using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemoUI.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            List<News> listModels = new List<News>();
            listModels.Add(new News() { ID = Guid.NewGuid(), AutherId = Guid.NewGuid(), Title = "新闻标题1这是一个长长的标题", Content = "新闻内容，新闻内容，新闻内容，新闻内容，内容新闻内容，新闻内容，新闻内容，新闻内容，内容新闻内容，新闻内容，新闻内容，新闻内容，内容新闻内容，新闻内容，新闻内容，新闻内容，内容新闻内容，新闻内容，新闻内容，新闻内容，内容新闻内容，新闻内容，新闻内容，新闻内容，内容", PortDate = DateTime.Now });
            ViewData.Model = listModels;
            return View();
        }

        // GET: News/Details/5
        public ActionResult Details(Guid id)
        {
            ViewData.Model = new News() { ID = Guid.NewGuid(), AutherId = Guid.NewGuid(), Title = "新闻标题1这是一个长长的标题", Content = "新闻内容，新闻内容，新闻内容，新闻内容，内容新闻内容，新闻内容，新闻内容，新闻内容，内容新闻内容，新闻内容，新闻内容，新闻内容，内容新闻内容，新闻内容，新闻内容，新闻内容，内容新闻内容，新闻内容，新闻内容，新闻内容，内容新闻内容，新闻内容，新闻内容，新闻内容，内容新闻内容，新闻内容，新闻内容，新闻内容，内容新闻内容，新闻内容，新闻内容，新闻内容，内容新闻内容，新闻内容，新闻内容，新闻内容，内容新闻内容，新闻内容，新闻内容，新闻内容，内容", PortDate = DateTime.Now };
            return View();
        }

        // GET: News/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: News/Create
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

        // GET: News/Edit/5
        /// <summary>
        /// int id
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit()
        {
            return View();
        }

        // POST: News/Edit/5
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

        // GET: News/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: News/Delete/5
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
