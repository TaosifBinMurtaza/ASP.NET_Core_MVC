using BookManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DataAccess.Repository.IRepository
{
    public interface ICoverType:IRepository<CoverType>
    {
        void Update(CoverType obj);
        

    }
}
