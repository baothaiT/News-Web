using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.Data;

namespace News.Controllers.Coordinator
{
    public class AcademicYearManagementController : Controller
    {
        private ApplicationDbContext _context;
        public AcademicYearManagementController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: AcademicYearController
        [Route("academicyearmanagement")]
        public ActionResult Index()
        {
            var query = _context.AcademicYear;
            return View(query);
        }

        // GET: AcademicYearController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AcademicYearController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AcademicYearController/Create
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

        // GET: AcademicYearController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AcademicYearController/Edit/5
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

        // GET: AcademicYearController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AcademicYearController/Delete/5
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
