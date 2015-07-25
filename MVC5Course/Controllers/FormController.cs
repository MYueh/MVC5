using MVC5Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class FormController : Controller
    {
        public ActionResult Index(SampleVM data)
        {
            //ModelState.Clear();

            var dt = new SampleVM() { Name = "Will", Title = "CTO" };

            ViewData["Name"] = "John";

            return View(dt);
        }
    }
}