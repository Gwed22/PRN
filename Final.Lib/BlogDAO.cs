using Final.Business.BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Lib
{
    public class BlogDAO
    {
        private static BlogDAO? instance;
        private static readonly object instanceLock = new object();
        private BlogDAO() { }
        public static BlogDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    instance ??= new BlogDAO();
                    return instance;
                }
            }
        }

        public IEnumerable<Blog> GetAll()
        {
            using var context = new ProjectPRNContext();
            List<Blog> list = context.Blogs.Include(c => c.Cate).ToList();
            return list;
        }

        public IEnumerable <Blog> GetBlogByCate(int? id)
        {
            using var context = new ProjectPRNContext();
            List<Blog> list = context.Blogs.Include(c => c.Cate).Where(c => c.CateId == id).ToList();
            return list;
        }

        public Blog GetById(int id)
        {
            using var context = new ProjectPRNContext();
            Blog acc = context.Blogs.SingleOrDefault(m => m.BlogId == id);
            return acc;
        }

        public void Add(Blog acc)
        {
            if (GetById(acc.BlogId) != null)
                throw new Exception("Blog has existed");
            using var context = new ProjectPRNContext();
            context.Blogs.Add(acc);
            context.SaveChanges();
        }

        public void Update(Blog acc)
        {
            if (GetById(acc.BlogId) == null)
                throw new Exception("Blog does not exist");
            using var context = new ProjectPRNContext();
            context.Blogs.Update(acc);
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            Blog? acc = GetById(id);
            if (acc == null)
                throw new Exception("Blog does not exist");
            using var context = new ProjectPRNContext();
            context.Blogs.Remove(acc);
            context.SaveChanges();
        }
    }
}
