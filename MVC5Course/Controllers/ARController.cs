using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class ARController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PartialViewTest()
        {
            return PartialView("MyPartial");
        }
    }
}