using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.Data;
using News.Models;
using System.Linq;

namespace News.Controllers.Staff
{
    public class BlogSingleController : Controller
    {
        private readonly ApplicationDbContext _context;
        public BlogSingleController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: BlogSingleController/Details/5
        [Route("blogsingle")]
        [HttpGet("{id}")]
        public ActionResult Details(string id)
        {
            var query = from a in _context.AppUser
                        join b in _context.Idea on a.Id equals b.idea_UserId
                        join c in _context.Categories on b.idea_CategoryId equals c.category_Id
                        join d in _context.Submission on b.idea_SubmissionId equals d.submission_Id
                        select new { a, b, c,d };
            query = query.Where(x => x.b.idea_Id == id);

            //Create Idea
            var blogModelQuery = query
                .Select(x => new DetailIdeaModels()
                {
                    idea_Id = x.b.idea_Id,
                    idea_Title = x.b.idea_Title,
                    idea_Description = x.b.idea_Description,
                    idea_ImageName = x.b.idea_ImageName,
                    idea_UpdateTime = x.b.idea_UpdateTime,
                    idea_UserName = x.a.UserName,
                    idea_CategoryName = x.c.category_Name,
                    idea_SubmissionName = x.d.submission_Name
                });

            //Start Query Idea
            var queryIdea = _context.Idea;
            ViewBag.IdeaList = queryIdea.ToList();
            //End Query Idea
            var queryComment = from a in _context.Comments
                               join b in _context.AppUser on a.cmt_UserId equals b.Id
                               select new { a, b };
            queryComment = queryComment.Where(x => x.a.cmt_IdeaId == id);
            var CommentInModel = queryComment
                .Select(x => new CommentsModels()
                {
                    cmt_Content = x.a.cmt_Content,
                    cmt_UserName = x.b.UserName,
                    cmt_UpdateDate = x.a.cmt_UpdateDate

                });
            ViewBag.CommentList = CommentInModel.ToList();
            //Start Query Comment


            //End Query Comment

            return View(blogModelQuery);
        }

        //// GET: BlogSingleController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: BlogSingleController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

    }
}
