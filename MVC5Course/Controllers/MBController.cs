using MVC5Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class MBController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(SampleVM data)
        {
            // 寫入資料
            if (ModelState.IsValid)
            {
                TempData["IndexSaveMsg"] = "新增" + data.Name + "成功";
                return RedirectToAction("IndexResult");
            }

            return View(data);
        }

        public ActionResult IndexResult()
        {
            return View();
        }
    }
}