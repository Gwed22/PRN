using Final.Business.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Lib.Repository
{
    public class CommentRepository : ICommentRepository
    {
        public IEnumerable<Comment> GetAll(int id) => CommentDAO.Instance.GetAll(id);
        
        public void Insert(Comment com) => CommentDAO.Instance.Add(com);
        public IEnumerable<Comment> GetAll() => CommentDAO.Instance.GetAll();

        public Comment? GetById(int id) => CommentDAO.Instance.GetById(id);
        public IEnumerable<Comment> GetByAccountName(string name) => CommentDAO.Instance.GetByAccountName(name);

        public void Remove(int id) => CommentDAO.Instance.Remove(id);

        public void Update(Comment comment) => CommentDAO.Instance.Update(comment);

    }
}
