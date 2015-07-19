using MVC5Course.ActionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace MVC5Course.Controllers
{
    public class AFController : BaseController
    {
        [取得共用的ViewBag資料]
        public ActionResult Index()
        {
            System.IO.File.AppendAllText(@"G:\MyFilter.log", "#2 AFController.Index()\n");

            //throw new Exception("Index failed");

            return View();
        }

        [取得共用的ViewBag資料]
        public ActionResult Page1()
        {
            return View();
        }

        [Authorize]
#if !DEBUG
        [RequireHttps]
#endif
        //[OutputCache(Duration = 60, Location = OutputCacheLocation.Server)]
        //[OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult Page2()
        {
            return View();
        }
    }
}