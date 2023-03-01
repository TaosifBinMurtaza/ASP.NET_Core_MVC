using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepo { get; }
        ICoverType CoverTypeRepo { get; }

        IProductRepository ProductRepo { get; }
        void Save();
    }
}
