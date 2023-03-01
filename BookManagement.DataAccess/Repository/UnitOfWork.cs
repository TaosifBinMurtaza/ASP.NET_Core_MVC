using BookManagement.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            CategoryRepo = new CategoryRepository(_db);
            CoverTypeRepo= new CoverTypeRepository(_db);
            ProductRepo=new ProductRepository(_db);

        }
       
        public ICategoryRepository CategoryRepo { get; private set; }

        public ICoverType CoverTypeRepo { get; private set; }

        public IProductRepository ProductRepo { get; private set; }




        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
