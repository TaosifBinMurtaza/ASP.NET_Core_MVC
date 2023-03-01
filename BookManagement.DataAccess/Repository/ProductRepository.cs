using BookManagement.DataAccess.Repository.IRepository;
using BookManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DataAccess.Repository
{
    internal class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
           // _db.Products.Update(obj);
           var p=(from s in _db.Products
                   where s.Id== obj.Id
                 select s).FirstOrDefault();
            if (p != null)
            {
                p.Title = obj.Title;
                p.Description = obj.Description;
                p.ISBN = obj.ISBN;
                p.Author = obj.Author;
                p.ListPrice = obj.ListPrice;
                p.Price = obj.Price;
                p.Price50 = obj.Price50;
                p.Price100 = obj.Price100;
                p.CategoryId= obj.CategoryId;
                if(p.ImageUrl!=null)
                {
                    p.ImageUrl = obj.ImageUrl;
                }
            }
        }

        
    }
}
