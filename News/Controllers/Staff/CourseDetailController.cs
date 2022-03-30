using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace News.Controllers.Staff
{
    public class CourseDetailController : Controller
    {
        // GET: CourseDetailController
        [Route("coursedetail")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: CourseDetailController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CourseDetailController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseDetailController/Create
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

        // GET: CourseDetailController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CourseDetailController/Edit/5
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

        // GET: CourseDetailController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CourseDetailController/Delete/5
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
