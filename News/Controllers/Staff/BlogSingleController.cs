using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace News.Controllers.Staff
{
    public class BlogSingleController : Controller
    {
        // GET: BlogSingleController
        [Route("blogsingle")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: BlogSingleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
