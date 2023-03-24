using Final.Business.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Lib
{
    public class AccountDAO
    {
        //Using Singleton Pattern
        private static AccountDAO instance = null;
        private static readonly object instanceLock = new object();
        public static AccountDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AccountDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Account> GetAll()
        {
            var mems = new List<Account>();
            try
            {
                using var context = new ProjectPRNContext();
                mems = context.Accounts.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return mems;
        }

        public Account GetById(int id)
        {
            Account mem = null;
            try
            {
                using var context = new ProjectPRNContext();
                mem = context.Accounts.SingleOrDefault(m => m.AccountId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return mem;
        }

        public void Add(Account account)
        {
            try
            {
                Account mem = GetById(account.AccountId);
                if (mem == null)
                {
                    using var context = new ProjectPRNContext();
                    context.Accounts.Add(account);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The account is already exist!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Account account)
        {
            try
            {
                Account mem = GetById(account.AccountId);
                if (mem != null)
                {
                    using var context = new ProjectPRNContext();
                    context.Accounts.Update(account);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The account does not already exist!");
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
                Account mem = GetById(id);
                if (mem != null)
                {
                    using var context = new ProjectPRNContext();
                    context.Accounts.Remove(mem);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The account does not already exist!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Account checkLogin(string email, string password)
        {
            Account account = null;
            try
            {
                using var context = new ProjectPRNContext();
                account = context.Accounts.SingleOrDefault(m => m.Email.Equals(email) && m.Password.Equals(password));
                if (account == null)
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return account;
        }
    }
}
