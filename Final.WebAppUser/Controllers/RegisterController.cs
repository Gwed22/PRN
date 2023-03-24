using Final.Business.BusinessObject;
using Final.Lib.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System.Linq;

namespace Final.WebAppUser.Controllers
{
    public class RegisterController : Controller
    {
        IAccountRepository accountRepository = null;
        public readonly ProjectPRNContext _projectPRNContext;
        public RegisterController()
        {
            accountRepository = new AccountRepository();
            _projectPRNContext = new ProjectPRNContext();
        }
        // GET: RegisterController
        public ActionResult Register()
        {
            return View();
        }

        // GET: RegisterController/Details/5

        // GET: RegisterController/Create


        // POST: RegisterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Account account)
        {
            if (ModelState.IsValid)
            {
                if (_projectPRNContext.Accounts.SingleOrDefault(a => a.Email == account.Email) == null)
                {
                    accountRepository.Insert(account);
                    return RedirectToAction("Index", "Login");
                }
                ViewBag.Message = "Duplicate Email";
            }
            return View();
        }
    }
}