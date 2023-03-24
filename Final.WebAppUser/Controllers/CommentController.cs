using Final.Business.BusinessObject;
using Final.Lib.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final.WebAppUser.Controllers
{
    public class CommentController : Controller
    {
        ICommentRepository commentRepository = null;
        public readonly ProjectPRNContext _projectPRNContext = new ProjectPRNContext();
        public CommentController() => commentRepository = new CommentRepository();
        // GET: CommentController
        public ActionResult Index(int id)
        {
            var blog = commentRepository.GetAll(id);
            return View("Blog/Details", blog);
        }

        // GET: CommentController/Details/5
        public ActionResult Comment(int blogid, int accid, string context)
        {
            if (HttpContext.Session.GetInt32("accId") == null)
            {
                return RedirectToAction("Index", "Login");

            }
            else
            {
                var cmt1 = commentRepository.GetAll(blogid);
                var cmt = new Comment
                {
                    BlogId = blogid,
                    AccountId = accid,
                    Context = context
                };
                commentRepository.Insert(cmt);
                ViewData["cmt"] = cmt1;
                ViewBag.BlogId = blogid;
                return RedirectToAction("Details", "Blog", new { id = blogid });
            }
        }
    }
}
