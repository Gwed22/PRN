using Final.Business.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Lib.Repository
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetAll(int id);
        void Insert(Comment com);
        IEnumerable<Comment> GetAll();
        Comment GetById(int id);
        IEnumerable<Comment> GetByAccountName(string name);
        void Update(Comment comment);
        void Remove(int id);
    }
}
