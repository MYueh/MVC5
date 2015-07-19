using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class VTController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.IsShow = true;
            ViewBag.msg = "Hello";

            ViewBag.num = new int[] { 1, 2, 3, 4, 5 };

            return PartialView();
        }
    }
}