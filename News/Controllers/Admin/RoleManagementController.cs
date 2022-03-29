using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.Data;
using News.Entities;

namespace News.Controllers.Admin
{
    public class RoleManagementController : Controller
    {
        private ApplicationDbContext _context;
        public RoleManagementController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: RoleManagementController
        [Route("/rolemanagement")]
        public ActionResult Index()
        {
            var query = _context.AppRole;
            return View(query);
        }

        // GET: RoleManagementController/Details/5
        [Route("/rolemanagement/details")]
        [HttpGet]
        public ActionResult Details(string id)
        {
            var query = _context.AppRole.Find(id);
            return View(query);
        }

        // GET: RoleManagementController/Create
        [Route("/rolemanagement/create")]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoleManagementController/Create
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

        // GET: RoleManagementController/Edit/5
        [Route("/rolemanagement/edit")]
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var query = _context.AppRole.Find(id);
            return View(query);
        }

        // POST: RoleManagementController/Edit/5
        [Route("/rolemanagement/edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, AppRole appRole)
        {
            try
            {
                var query = _context.AppRole.Find(appRole.Id);
                query.Name = appRole.Name;
                query.Description = appRole.Description;
                query.NormalizedName = appRole.NormalizedName;
                query.ConcurrencyStamp = appRole.ConcurrencyStamp;

                _context.AppRole.Update(query);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoleManagementController/Delete/5
        [Route("/rolemanagement/delete")]
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var query = _context.AppRole.Find(id);
            return View(query);
        }

        // POST: RoleManagementController/Delete/5
        [Route("/rolemanagement/delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var query = _context.AppRole.Find(id);
                _context.AppRole.Remove(query);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
