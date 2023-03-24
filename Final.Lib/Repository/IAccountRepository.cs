using Final.Business.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Lib.Repository
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAll();
        Account GetById(int id);
        void Insert(Account account);
        void Update(Account account);
        void Remove(int id);
        Account checkLogin(string email, string password);
    }
}
