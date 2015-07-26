using MVC5Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class EnumController : Controller
    {
        // GET: Enum
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Show()
        {
            var data = new SampleVM()
            {
                Title = "CTO",
                Name = "Will",
                Level = 5,
                Gender = GenderEnum.中性 | GenderEnum.男性
            };

            return View(data);
        }
    }
}