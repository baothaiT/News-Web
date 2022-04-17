using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.Data;
using News.Entities;
using News.Models;
using System.Linq;

namespace News.Controllers.Coordinator
{
    public class IdeaPendingController : Controller
    {
        private readonly ApplicationDbContext _context;
        public IdeaPendingController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: IdeaPendingController
        [Route("ideapendingmanagement")]
        [HttpGet]
        public ActionResult Index()
        {
            var query = from a in _context.Idea
                        join b in _context.Submission on a.idea_SubmissionId equals b.submission_Id
                        select new { a, b };
            query = query.Where(x => x.a.IsDelete == false && x.a.idea_UserId == null);
            //Create Idea
            var blogModelQuery = query
                .Select(x => new DetailIdeaModels()
                {
                    idea_Id = x.a.idea_Id,
                    idea_Title = x.a.idea_Title,
                    idea_Description = x.a.idea_Description,
                    idea_UpdateTime = x.a.idea_UpdateTime,
                    idea_SubmissionName = x.b.submission_Name
                });


            return View(blogModelQuery);
        }

        // GET: IdeaPendingController/Details/5
        [Route("ideapendingmanagement/details")]
        [HttpGet]
        public ActionResult Details(string id)
        {
            var query = from a in _context.Idea
                        join b in _context.Submission on a.idea_SubmissionId equals b.submission_Id
                        select new { a, b };
            query = query.Where(x => x.a.IsDelete == false && x.a.idea_UserId == null);
            //Create Idea
            var blogModelQuery = query
                .Select(x => new DetailIdeaModels()
                {
                    idea_Id = x.a.idea_Id,
                    idea_Title = x.a.idea_Title,
                    idea_Description = x.a.idea_Description,
                    idea_UpdateTime = x.a.idea_UpdateTime,
                    idea_SubmissionName = x.b.submission_Name
                });

            var blogModels = blogModelQuery.FirstOrDefault(x => x.idea_Id == id);
            return View(blogModels);
        }




        // GET: IdeaPendingController/Edit/5
        [Route("ideapendingmanagement/appoval")]
        [HttpGet("{id}")]
        public ActionResult Appoval(string id)
        {
            //Query Idea
            var queryIdea = _context.Idea.FirstOrDefault(a => a.idea_Id == id);

            //Query UserId 
            var queryUserId = _context.AppUser.FirstOrDefault(a => a.UserName == "Anonymous");

            queryIdea.idea_UserId = queryUserId.Id;

            _context.Idea.Update(queryIdea);
            _context.SaveChanges();


            return Redirect("/ideamanagement");
        }


        // GET: IdeaPendingController/Delete/5
        [Route("ideapendingmanagement/delete")]
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var query = _context.Idea.FirstOrDefault(a => a.idea_Id == id);
            return RedirectToAction(nameof(Index));
        }

        // POST: IdeaPendingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, Idea idea)
        {
            try
            {
                var query = _context.Idea.FirstOrDefault(a => a.idea_Id == idea.idea_Id);
                _context.Idea.Remove(query);
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
