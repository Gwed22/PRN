using Final.Business.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Lib.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
       
    }
}
