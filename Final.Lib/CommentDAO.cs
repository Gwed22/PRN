using Final.Business.BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Lib
{
    public class CommentDAO
    {
        private static CommentDAO instance = null;
        private static readonly object instanceLock = new object();
        public static CommentDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CommentDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Comment> GetAll(int id)
        {
            var com = new List<Comment>();
            try
            {
                using var context = new ProjectPRNContext();
                com = context.Comments.Include(c=>c.Account).Where(c=> c.BlogId == id).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return com;
        }

        public void Add(Comment com)
        {
            using var context = new ProjectPRNContext();
            context.Comments.Add(com);
            context.SaveChanges();
        }

        public IEnumerable<Comment> GetAll()
        {
            var mems = new List<Comment>();
            try
            {
                using var context = new ProjectPRNContext();
                mems = context.Comments.Include(a => a.Account).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return mems;
        }

        public Comment GetById(int id)
        {
            Comment mem = null;
            try
            {
                using var context = new ProjectPRNContext();
                mem = context.Comments.SingleOrDefault(m => m.CommentId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return mem;
        }

        public IEnumerable<Comment> GetByAccountName(String name)
        {
            var list = new List<Comment>();
            try
            {
                using var context = new ProjectPRNContext();
                list = context.Comments.Include(a => a.Account).Where(a => a.Account.FullName.Contains(name)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public void Update(Comment comment)
        {
            try
            {
                Comment mem = GetById(comment.CommentId);
                if (mem != null)
                {
                    using var context = new ProjectPRNContext();
                    context.Comments.Update(comment);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The comment does not already exist!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(int id)
        {
            try
            {
                Comment mem = GetById(id);
                if (mem != null)
                {
                    using var context = new ProjectPRNContext();
                    context.Comments.Remove(mem);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The comment does not already exist!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
