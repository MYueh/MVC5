using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC5Course.Models;

namespace MVC5Course.Controllers
{
    public class ProductsController : BaseController
    {
        //private FabricsEntities db = new FabricsEntities();

        ProductRepository repo = RepositoryHelper.GetProductRepository();
        

        // GET: Products
        public ActionResult Index()
        {
            //var dat0 = db.Product.Take(10).ToList();
            var data = repo.取得前五筆產品資料().ToList();
            return View(data);
        }

        [HttpPost]
        public ActionResult Index(List<UpdateStockVM> data)
        {
            if (ModelState.IsValid)
            {
                foreach (var item in data)
                {
                    db.Product.Find(item.ProductId).Stock = item.Stock;
                }

                db.SaveChanges();

                return RedirectToAction("Index");
            }

            //ModelState.Remove("data[0].Stock");
            //ModelState.Clear();

            return View(repo.取得前五筆產品資料().ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Product product = db.Product.Find(id);
            //Product product = repo.All().Where(p => p.ProductId == id.Value).First();
            
            
            Product product = repo.Find(id.Value);


            //ViewBag.OrderLines = product.OrderLine.ToList();


            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductId,ProductName,Price,Active,Stock")] Product product)
        {
            if (ModelState.IsValid)
            {
                //db.Product.Add(product);
                //db.SaveChanges();
                repo.Add(product);
                repo.UnitOfWork.Commit();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id, string any)
        {
            ViewBag.any = any;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Product product = db.Product.Find(id);
            Product product = repo.Find(id.Value);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[ValidateInput(false)]
        public ActionResult Edit(int ProductId, FormCollection form)
        {
            var product = repo.Find(ProductId);

            if (TryUpdateModel<Product>(product))
            {
                //db.Entry(product).State = EntityState.Modified;
                //db.SaveChanges();
                ((FabricsEntities)repo.UnitOfWork.Context).Entry(product).State = EntityState.Modified;
                repo.UnitOfWork.Commit();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Product product = db.Product.Find(id);
            var product = repo.Find(id.Value);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Product product = db.Product.Find(id);
            //db.Product.Remove(product);
            //db.SaveChanges();
            repo.Delete(repo.Find(id));
            repo.UnitOfWork.Commit();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
                ((FabricsEntities)repo.UnitOfWork.Context).Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
