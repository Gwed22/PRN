using Final.Business.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Lib.Repository
{
    public class AccountRepository : IAccountRepository
    {
        public IEnumerable<Account> GetAll() => AccountDAO.Instance.GetAll();

        public Account? GetById(int id) => AccountDAO.Instance.GetById(id);

        public void Insert(Account acc) => AccountDAO.Instance.Add(acc);

        public void Remove(int id) => AccountDAO.Instance.Remove(id);

        public void Update(Account acc) => AccountDAO.Instance.Update(acc);

        public Account checkLogin(string email, string password) => AccountDAO.Instance.checkLogin(email, password);
    }
}
