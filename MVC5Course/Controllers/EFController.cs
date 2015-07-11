using MVC5Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class EFController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public int AddProduct()
        {
            using (var db = new FabricsEntities())
            {
                var product = new Product()
                {
                    ProductName = "T-Shirt",
                    Price = 199,
                    Active = true,
                    Stock = 10
                };

                db.Product.Add(product);

                db.SaveChanges();

                return product.ProductId;
            }
        }


    }
}