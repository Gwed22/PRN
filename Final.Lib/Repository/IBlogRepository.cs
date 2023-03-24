using Final.Business.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Lib.Repository
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> GetAll();

        IEnumerable<Blog> GetBlogs(int? id);
        Blog GetById(int id);
        void Insert(Blog blog);
        void Update(Blog blog);
        void Remove(int id);
    }
}
