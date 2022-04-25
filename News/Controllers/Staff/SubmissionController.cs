using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.Data;
using News.Models;
using System;
using System.Linq;

namespace News.Controllers.Staff
{
    public class SubmissionController : Controller
    {
        private readonly ApplicationDbContext _context;
        public SubmissionController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: CourseController
        [Route("submission")]
        public ActionResult Index()
        {
            //Class Active menu
            ViewBag.CourseActive = "active";

            //Query Submission
            var querySubmission = _context.Submission.Where(a => a.IsDelete == false);

            var dateNow = DateTime.Now;

            var submissionModelQuery = querySubmission
                .Select(x => new SubmissionModels()
                {
                    submission_Id = x.submission_Id,
                    submission_Name = x.submission_Name,
                    submission_Description = x.submission_Description,
                    submission_StartTime = x.submission_StartTime,
                    submission_DueTime = x.submission_DueTime,
                    Block = (x.submission_DueTime >= dateNow)? false : true,
                });

            //Start Query Idea
            var queryIdea = _context.Idea;
            ViewBag.IdeaList = queryIdea.ToList();
            //End Query Idea


            return View(submissionModelQuery);
        }

        
    }
}
