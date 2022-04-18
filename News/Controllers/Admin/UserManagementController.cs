using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using News.Data;
using News.Entities;
using News.Models;
using System.Linq;
using System.Threading.Tasks;

namespace News.Controllers.Admin
{
    [Authorize(Roles = "Admin")]
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
            var query = _context.AppUser.Where(a => a.IsDelete == false);
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

                query.IsDelete = true;
                query.EmailConfirmed = false;
                //Error
                _context.AppUser.Update(query);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [Route("/AssignToRole")]
        [HttpGet]
        public ActionResult AssignToRole(string id)
        {
            try
            {
                //Check and Query Infomation
                var userQuery = _context.AppUser.FirstOrDefault(a => a.Id == id);
                var roleQuery = from a in _context.AppRole select a;
                roleQuery = roleQuery.Where(x => x.IsDelete == false);
                var checkUserInRole = _context.UserRoles.FirstOrDefault(a => a.UserId == id);
                ViewBag.RoleName = "";


                if (checkUserInRole != null)
                {
                    var RoleName = _context.AppRole.FirstOrDefault(a => a.Id == checkUserInRole.RoleId);
                    ViewBag.RoleName = RoleName.Name;
                }
                ViewBag.Id = id;
                ViewBag.UserName = userQuery.UserName;
                ViewBag.FirstName = userQuery.FirstName;
                ViewBag.LastName = userQuery.LastName;
                ViewBag.Email = userQuery.Email;

                ViewBag.Role = roleQuery;
                return View();
            }
            catch 
            {

                return View();
            }
        }
        [Route("/AssignToRole")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AssignToRole(AssignToRoleModels assignToRoleModels)
        {
            try
            {
                var roleQuery = _context.AppRole.FirstOrDefault(a => a.Id == assignToRoleModels.UserId);

                string idUser = assignToRoleModels.UserId;

                var RoleName = _context.AppRole.FirstOrDefault(a => a.Id == assignToRoleModels.RoleId);
                var UserQueryName = _context.AppUser.FirstOrDefault(a => a.Id == idUser);

                // Delete Role
                var checkUserInRole = _context.UserRoles.FirstOrDefault(a => a.UserId == idUser);
                if (checkUserInRole != null)
                {
                    _context.UserRoles.Remove(checkUserInRole);
                    //await _userManager.RemoveFromRoleAsync(UserQueryName, RoleName);
                }
                await _userManager.AddToRoleAsync(UserQueryName, RoleName.Name);
                //_context.UserRoles.Add(createUserRole);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
    }
}
 