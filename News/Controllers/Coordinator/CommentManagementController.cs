using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.Data;
using News.Entities;

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
        public ActionResult Delete(string id)
        {
            var query = _context.Comments.Find(id);
            return View(query);
        }

        // POST: CommentManagementController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, Comments comments)
        {
            try
            {
                var query = _context.Comments.Find(comments.cmt_Id);
                _context.Comments.Remove(query);
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
