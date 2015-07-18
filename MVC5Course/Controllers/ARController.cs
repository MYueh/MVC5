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
            string str = "Hello, World";

            return View((object)str);
        }

        public ActionResult PartialViewTest()
        {
            return PartialView("MyPartial");
        }

        public ActionResult ContentTest()
        {
            return Content("<h1>ContentTest</h1>", "text/plain");
        }
        public ActionResult ContentTest2()
        {
            //Response.Write("<script>alert('新增成功'); location.href='/';</script>");
            return Content("<script>alert('新增成功'); location.href='/';</script>");
        }
        public ActionResult ContentTest3()
        {
            ViewBag.msg = "新增成功";

            return View("AlertRedirect");
        }

        public ActionResult FileTest()
        {
            return File(Server.MapPath("~/Content/hqdefault.jpg"), "image/jpeg", "泛舟哥.jpg");
        }
    }
}