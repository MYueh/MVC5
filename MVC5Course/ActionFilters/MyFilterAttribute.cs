using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.ActionFilters
{
    public class MyFilterAttribute : ActionFilterAttribute, IExceptionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            File.AppendAllText(@"G:\MyFilter.log", "#1 OnActionExecuting\n");
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            File.AppendAllText(@"G:\MyFilter.log", "#3 OnActionExecuted\n");

            base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            File.AppendAllText(@"G:\MyFilter.log", "#4 OnResultExecuting\n");

            base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            File.AppendAllText(@"G:\MyFilter.log", "#6 OnResultExecuted\n");

            base.OnResultExecuted(filterContext);
        }

        public void OnException(ExceptionContext filterContext)
        {
            File.AppendAllText(@"G:\MyFilter.log", "#7 OnException\n");
        }
    }
}