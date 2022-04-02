using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.Data;
using News.Entities;

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
        [Route("categoriesmanagement/details")]
        [HttpGet]
        public ActionResult Details(string id)
        {
            var query = _context.Categories.Find(id);
            return View(query);
        }

        // GET: CategoriesManagementController/Create
        [Route("categoriesmanagement/create")]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesManagementController/Create
        [Route("categoriesmanagement/create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categories categories)
        {
            try
            {
                var newCategories = new Categories()
                {
                    category_Name = categories.category_Name,
                    category_Description = categories.category_Description,
                };

                _context.Categories.Add(newCategories);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesManagementController/Edit/5
        [Route("categoriesmanagement/edit")]
        public ActionResult Edit(string id)
        {
            var query = _context.Categories.Find(id);
            return View(query);
        }

        // POST: CategoriesManagementController/Edit/5
        [Route("categoriesmanagement/edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Categories categories)
        {
            try
            {
                var query = _context.Categories.Find(categories.category_Id);
                query.category_Name = categories.category_Name;
                query.category_Description = categories.category_Description;

                _context.Categories.Update(query);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesManagementController/Delete/5
        [Route("categoriesmanagement/delete")]
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var query = _context.Categories.Find(id);
            return View(query);
        }

        // POST: CategoriesManagementController/Delete/5
        [Route("categoriesmanagement/delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, Categories categories)
        {
            try
            {
                var query = _context.Categories.Find(categories.category_Id);

                _context.Categories.Remove(query);
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
