using System.Web.Mvc;

namespace MVC5Course.Areas.AT
{
    public class ATAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AT";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AT_default",
                "AT/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}