using Final.Business.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Lib.Repository
{
    public class BlogRepository : IBlogRepository
    {
        public IEnumerable<Blog> GetAll() => BlogDAO.Instance.GetAll();

        public IEnumerable<Blog> GetBlogs(int? id) => BlogDAO.Instance.GetBlogByCate(id);

        

        public Blog GetById(int id) => BlogDAO.Instance.GetById(id);

        public void Insert(Blog blog) => BlogDAO.Instance.Add(blog);

        public void Remove(int id) => BlogDAO.Instance.Remove(id);

        public void Update(Blog blog) => BlogDAO.Instance.Update(blog);

    }
}
