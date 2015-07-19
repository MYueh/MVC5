using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.ActionFilters
{
    public class MyFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            File.AppendAllText(@"G:\MyFilter.log", "#1\n");
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            File.AppendAllText(@"G:\MyFilter.log", "#3\n");

            base.OnActionExecuted(filterContext);
        }
    }
}