using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using News.Data;
using News.Entities;
using System.Threading.Tasks;

namespace News.Controllers.Admin
{
    public class UserManagementController : Controller
    {
        private ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public UserManagementController(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: UserManagementController
        [Route("usermanagement")]
        public ActionResult Index()
        {
            var query = _context.AppUser;
            return View(query);
        }

        // GET: UserManagementController/Details/5
        [Route("usermanagement/details")]
        [HttpGet]
        public ActionResult Details(string id)
        {
            var query = _context.AppUser.Find(id);
            return View(query);
        }

        // GET: UserManagementController/Create
        [Route("usermanagement/create")]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserManagementController/Create
        [Route("usermanagement/create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(AppUser appUser)
        {
            try
            {
                var user = new AppUser { UserName = appUser.Email, Email = appUser.Email };
                var result = await _userManager.CreateAsync(user, appUser.PasswordHash);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserManagementController/Edit/5
        [Route("usermanagement/edit")]
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var query = _context.AppUser.Find(id);
            return View(query);
        }

        // POST: UserManagementController/Edit/5
        [Route("usermanagement/edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, AppUser appUser)
        {
            try
            {
                var query = _context.AppUser.Find(appUser.Id);
                query.UserName = appUser.UserName;
                query.FirstName = appUser.FirstName;
                query.LastName = appUser.LastName;
                query.Email = appUser.Email;

                _context.AppUser.Update(query);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserManagementController/Delete/5
        [Route("usermanagement/delete")]
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var query = _context.AppUser.Find(id);
            return View(query);
        }

        // POST: UserManagementController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, AppUser appUser)
        {
            try
            {
                var query = _context.AppUser.Find(appUser.Id);
                //Error
                _context.AppUser.Remove(query);
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
