using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PartialViewTest()
        {
            return PartialView("MyPartial");
        }

        [HandleError(View = "Error", ExceptionType = typeof(Exception))]
        [HandleError(View = "Error2", ExceptionType = typeof(ArgumentException))]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new ArgumentException("發生錯誤");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult NewLayout()
        {
            return View();
        }
    }
}