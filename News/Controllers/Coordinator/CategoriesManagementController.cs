using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.Data;

namespace News.Controllers.Coordinator
{
    public class CategoriesManagementController : Controller
    {

        private ApplicationDbContext _context;
        public CategoriesManagementController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CategoriesManagementController
        [Route("categoriesmanagement")]
        public ActionResult Index()
        {
            var query = _context.Categories;
            return View(query);
        }

        // GET: CategoriesManagementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoriesManagementController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesManagementController/Create
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

        // GET: CategoriesManagementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriesManagementController/Edit/5
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

        // GET: CategoriesManagementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriesManagementController/Delete/5
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
