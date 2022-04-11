using Food.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using News.Data;
using News.Models;
using System.Linq;

namespace News.Controllers.Staff
{
    public class BlogArchiveController : Controller
    {
        private ApplicationDbContext _context;
        public BlogArchiveController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: BlogArchiveController
        [Route("blogarchive")]
        public ActionResult Index(int? pageNumber , string sortOrder, string currentFilter)
        {
            //Class active 
            ViewBag.BlogActive = "active";

            //Query Blog
            var query = from s in _context.Idea
                        orderby s.idea_UpdateTime descending
                        select s;

            //Create Idea
            var blogModelQuery = query
                .Select(x => new BlogArchiveModels()
                {
                    Id = x.idea_Id,
                    Title = x.idea_Title,
                    Img = x.idea_ImageName,
                    UserName = "",
                    CountComment = 20,
                    ShortDescription = "",
                    UpdateTime = x.idea_UpdateTime

                });
            int pageSize = 8;
            return View(PaginatedList<BlogArchiveModels>.Create(blogModelQuery.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: BlogArchiveController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BlogArchiveController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogArchiveController/Create
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

        // GET: BlogArchiveController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlogArchiveController/Edit/5
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

        // GET: BlogArchiveController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlogArchiveController/Delete/5
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
    }
}
