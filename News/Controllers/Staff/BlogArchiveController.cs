using Food.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using News.Data;
using News.Models;
using System.Linq;

namespace News.Controllers.Staff
{
    public class BlogArchiveController : Controller
    {
        private ApplicationDbContext _context;
        public BlogArchiveController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: BlogArchiveController
        [Route("blogarchive")]
        [HttpGet("{typeSort,submissionId}")]
        public ActionResult Index(int? pageNumber , string sortOrder, string currentFilter,string typeSort, string submissionId)
        {
            //Class active 
            ViewBag.BlogActive = "active";


            var query = from a in _context.Idea select a ;

            query = query.Where(a => a.idea_UserId != null);
            if (submissionId is not null)
            {
                query = query.Where(x => x.idea_SubmissionId == submissionId);
            }
            
            query = query.OrderByDescending(s => s.idea_UpdateTime);

            //Create Idea
            var blogModelQuery = query
                .Select(x => new BlogArchiveModels()
                {
                    Id = x.idea_Id,
                    Title = x.idea_Title,
                    Img = x.idea_ImageName,
                    UserName = "",
                    ShortDescription = "",
                    UpdateTime = x.idea_UpdateTime,
                    CountComment = _context.Comments.Where(s => s.cmt_IdeaId == x.idea_Id).Count(),
                    View = x.idea_View
                });


            //Sort
            if (typeSort != "")
            {
                switch (typeSort)
                {
                    case "MostView":
                        // code block
                        blogModelQuery = blogModelQuery.OrderByDescending(s => s.View);
                        break;
                    case "Popular":
                        // code block
                        blogModelQuery = blogModelQuery.OrderByDescending(s => s.CountComment);
                        break;
                    default:
                        // code block
                        break;
                }
            }
            

            
            //Start Query Idea
            var queryIdea = _context.Idea;
            ViewBag.IdeaList = queryIdea.ToList();
            //End Query Idea

            int pageSize = 6;
            return View(PaginatedList<BlogArchiveModels>.Create(blogModelQuery.AsNoTracking(), pageNumber ?? 1, pageSize));
        }


    }
}
