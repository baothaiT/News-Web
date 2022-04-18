using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.Data;

namespace News.Controllers.Coordinator
{
    [Authorize(Roles = "Admin,Staff")]
    public class ContactUserManagementController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ContactUserManagementController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: ContactUserManagementController
        [Route("contactusermanagement")]
        public ActionResult Index()
        {
            var query = _context.ContactEmail;
            return View(query);
        }
    }
}
