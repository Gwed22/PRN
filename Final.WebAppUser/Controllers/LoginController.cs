using Final.Business.BusinessObject;
using Final.Lib.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Final.WebAppUser.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Blog");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index([FromForm] string email, [FromForm] string password)
        {
            try
            {
                IAccountRepository account = new AccountRepository();
                Account loginMember = account.checkLogin(email, password);

                if (loginMember != null)
                {
                    HttpContext.Session.SetInt32("accId", loginMember.AccountId);
                    HttpContext.Session.SetString("name", loginMember.FullName);
                    return RedirectToAction("Index", "Blog");
                }

                return RedirectToAction("Index", "Login");
            }
            catch (Exception ex)
            {
                ViewBag.Email = email;
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
