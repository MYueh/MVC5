using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.ActionFilters
{
    public class 取得共用的ViewBag資料Attribute : ActionFilterAttribute, IExceptionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            File.AppendAllText(@"G:\MyFilter.log", "#1 OnActionExecuting - " + filterContext.RouteData.Values["controller"] + "." + filterContext.RouteData.Values["action"] + "()\n");

            filterContext.Controller.ViewBag.msg = "Hello, AF!";

            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            File.AppendAllText(@"G:\MyFilter.log", "#3 OnActionExecuted - " + filterContext.RouteData.Values["controller"] + "." + filterContext.RouteData.Values["action"] + "()\n");

            base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            File.AppendAllText(@"G:\MyFilter.log", "#4 OnResultExecuting - " + filterContext.RouteData.Values["controller"] + "." + filterContext.RouteData.Values["action"] + "()\n");

            base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            File.AppendAllText(@"G:\MyFilter.log", "#6 OnResultExecuted - " + filterContext.RouteData.Values["controller"] + "." + filterContext.RouteData.Values["action"] + "()\n");

            base.OnResultExecuted(filterContext);
        }

        public void OnException(ExceptionContext filterContext)
        {
            File.AppendAllText(@"G:\MyFilter.log", "#7 OnException - " + filterContext.RouteData.Values["controller"] + "." + filterContext.RouteData.Values["action"] + "()\n");
        }
    }
}