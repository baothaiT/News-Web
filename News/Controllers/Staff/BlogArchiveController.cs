using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public ActionResult Index()
        {
            //Class active 
            ViewBag.BlogActive = "active";

            //Query Blog
            var query = from s in _context.Idea
                        orderby s.idea_UpdateTime descending
                        select s;

            return View(query);
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
