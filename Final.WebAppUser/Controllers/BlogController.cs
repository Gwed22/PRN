using Final.Lib.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using Final.Business.BusinessObject;

namespace Final.WebAppUser.Controllers
{
    public class BlogController : Controller
    {
        IBlogRepository blogRepository = null;
        ICommentRepository commentRepository = new CommentRepository();
        ICategoryRepository categoryRepository = new CategoryRepository();
        public BlogController() => blogRepository = new BlogRepository();
        
        // GET: BlogController
        public ActionResult Index(int? id)
        {
            var cate = categoryRepository.GetAll();
            ViewData["cate"] = cate;
            var blog = blogRepository.GetBlogs(id);
            if (id != null)
            {
                return View("Index", blog);
            }
            var blogList = blogRepository.GetAll();
            return View(blogList);
        }

        // GET: BlogController/Details/5
        public ActionResult Details(int id)
        {
            var cmt = commentRepository.GetAll(id);
            var blog = blogRepository.GetById(id);
            if (blog == null)
                return NotFound();
            ViewData["cmt"] = cmt;
            return View(blog);
           
        }

        // GET: BlogController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlogController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlogController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult Search(String query)
        {
            
            var cate = categoryRepository.GetAll();
            ViewData["cate"] = cate;
            if (query != null)
            {
                var model = blogRepository.GetAll().Where(emp => emp.Title.ToLower().Contains(query.ToLower()));
                if (model.Count() == 0)
                {
                    ViewBag.Message = "Tim khong thay";
                    return View("Index", model);
                }
                return View("Index", model);
            }
            
            return Redirect("Index");


        }
        public ActionResult SortByDateAsc()
        {
            var cate = categoryRepository.GetAll();
            ViewData["cate"] = cate;
            var model = blogRepository.GetAll().OrderBy(x => x.DatePost).ToList();
            return View("Index", model);
        }
        public ActionResult SortByDateDsc()
        {
            var cate = categoryRepository.GetAll();
            ViewData["cate"] = cate;
            var model = blogRepository.GetAll().OrderByDescending(x => x.DatePost).ToList();
            return View("Index", model);
        }
        public ActionResult SortByNameAsc()
        {
            var cate = categoryRepository.GetAll();
            ViewData["cate"] = cate;
            var model = blogRepository.GetAll().OrderBy(x => x.Title).ToList();
            return View("Index", model);
        }
        public ActionResult SortByNameDsc()
        {
            var cate = categoryRepository.GetAll();
            ViewData["cate"] = cate;
            var model = blogRepository.GetAll().OrderByDescending(x => x.Title).ToList();
            return View("Index", model);
        }

       
    }
}
