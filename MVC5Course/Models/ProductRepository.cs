using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5Course.Models
{   
	public  class ProductRepository : EFRepository<Product>, IProductRepository
	{
        public override IQueryable<Product> All()
        {
            return base.All().Where(p => p.Active == true);
        }

        public IQueryable<Product> 取得前五筆產品資料()
        {
            return this.All().Take(5);
        }

        public Product Find(int id)
        {
            return this.All().FirstOrDefault(p => p.ProductId == id);
        }

        public override void Delete(Product entity)
        {
            entity.Active = false;
        }

        public override void Add(Product entity)
        {
            base.Add(entity);
        }
        
	}

	public  interface IProductRepository : IRepository<Product>
	{

	}
}