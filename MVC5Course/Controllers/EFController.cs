using MVC5Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class EFController : Controller
    {
        private FabricsEntities db = new FabricsEntities();

        public ActionResult Index()
        {
            #region Option 1

            //using (var db = new FabricsEntities())
            //{
            //    var data = db.Product.Where(p => p.ProductId > 1500).ToList();

            //    return View(data);
            //}

            #endregion

            #region Option 2

            var data = db.Product.Where(p => p.ProductId > 1500);

            return View(data);

            #endregion
        }

        public int AddProduct()
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

        public ActionResult RemoveProduct(int id = 0)
        {
            var prod = db.Product.Find(id);

            if (prod == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            //db.Product.Remove(prod);

            prod.Active = false;

            db.SaveChanges();

            return View(prod);
        }

        public ActionResult RemoveClient()
        {
            var data = db.Client.Take(5);

            foreach (var client in data)
            {
                //var order = db.Order.Where(p => p.ClientId == client.ClientId)
                foreach (var order in client.Order)
                {
                    //foreach (var orderLine in order.OrderLine)
                    //{
                    //}
                    db.OrderLine.RemoveRange(order.OrderLine);
                }

                db.Order.RemoveRange(client.Order);
            }

            db.Client.RemoveRange(data);

            db.SaveChanges();

            return View(data);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}