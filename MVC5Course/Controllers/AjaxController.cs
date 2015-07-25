using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class AjaxController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetTime()
        {
            return Content(DateTime.Now.ToString());
        }
    }
}