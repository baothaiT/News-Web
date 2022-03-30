using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace News.Controllers.Staff
{
    public class GalleryController : Controller
    {
        // GET: GalleryController
        [Route("gallery")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: GalleryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GalleryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GalleryController/Create
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

        // GET: GalleryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GalleryController/Edit/5
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

        // GET: GalleryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GalleryController/Delete/5
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
