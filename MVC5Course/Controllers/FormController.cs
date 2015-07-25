using MVC5Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class FormController : BaseController
    {
        public ActionResult Index(SampleVM data)
        {
            //ModelState.Clear();

            var dt = new SampleVM() { Name = "Will", Title = "CTO" };

            ViewData["Name"] = "John";

            //var list = new List<SelectListItem>();

            //list.Add(new SelectListItem() { Text = "進階班", Value = "3" });
            //list.Add(new SelectListItem() { Text = "中級班", Value = "2" });
            //list.Add(new SelectListItem() { Text = "初階班", Value = "1" });

            //ViewData["LevelOptions"] = new SelectList(list, "Value", "Text", 1);


            ViewData["LevelOptions"] = new SelectList(db.Occupation.ToList(),
                "OccupationId", "OccupationName");


            return View(dt);
        }
    }
}