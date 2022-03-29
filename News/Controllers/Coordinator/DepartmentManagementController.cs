using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.Data;

namespace News.Controllers.Coordinator
{
    public class DepartmentManagementController : Controller
    {
        private ApplicationDbContext _context;
        public DepartmentManagementController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: DepartmentManagementController
        [Route("departmentmanagement")]
        public ActionResult Index()
        {
            var query = _context.Department;
            return View(query);
        }

        // GET: DepartmentManagementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DepartmentManagementController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentManagementController/Create
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

        // GET: DepartmentManagementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DepartmentManagementController/Edit/5
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

        // GET: DepartmentManagementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DepartmentManagementController/Delete/5
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
