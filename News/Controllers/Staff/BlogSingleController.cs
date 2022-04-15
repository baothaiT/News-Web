using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.Data;

namespace News.Controllers.Staff
{
    public class BlogSingleController : Controller
    {
        private readonly ApplicationDbContext _context;
        public BlogSingleController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: BlogSingleController
        [Route("blogsinglelist")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: BlogSingleController/Details/5
        [Route("blogsingle")]
        [HttpGet]
        public ActionResult Details(string id)
        {
            var queryIdea = _context.Idea.Find(id);

            ViewBag.Img = queryIdea.idea_ImageName;
            ViewData["content"] = queryIdea.idea_Description;


            return View(queryIdea);
        }

        // GET: BlogSingleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogSingleController/Create
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

        // GET: BlogSingleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlogSingleController/Edit/5
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

        // GET: BlogSingleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlogSingleController/Delete/5
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
