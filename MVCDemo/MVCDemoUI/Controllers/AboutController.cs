using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemoUI.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            //1、获取【关于我们】数据
            string title = "这里是关于我们的标题";
            string content = "这里是关于我们的内容这里是关于我们的内容这里是关于我们的内容这里是关于我们的内容这里是关于我们的内容这里是关于我们的内容";
            ViewData["aboutTitle"] = title;
            ViewData["aboutContent"] = content;
            //2、获取【what】数据
            string whatImgLink = "../Content/images/crop.jpg";
            string whatContent = "此处展示我们正在做的东西。此处展示我们正在做的东西。此处展示我们正在做的东西。此处展示我们正在做的东西。此处展示我们正在做的东西。此处展示我们正在做的东西。";
            string whatLink = "#";
            ViewData["whatImgLink"] = whatImgLink;
            ViewData["whatContent"] = whatContent;
            ViewData["whatLink"] = whatLink;
            //3、获取【why】数据
            List<string> listStr = new List<string>() { "优势1的详细信息", "优势2的详细信息", "优势3的详细信息", "优势4的详细信息", "优势5的详细信息" };
            ViewData["PerfectList"] = listStr;

            return View();
        }

        // GET: About/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: About/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: About/Create
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

        // GET: About/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: About/Edit/5
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

        // GET: About/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: About/Delete/5
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
