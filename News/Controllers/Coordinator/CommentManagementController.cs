using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.Data;

namespace News.Controllers.Coordinator
{
    public class CommentManagementController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CommentManagementController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: CommentManagementController
        [Route("commentmanagement")]
        public ActionResult Index()
        {
            var query = _context.Comments;
            return View(query);
        }

        
        // GET: CommentManagementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CommentManagementController/Delete/5
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
