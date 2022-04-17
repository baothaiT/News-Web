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
            var querySubmission = _context.Submission;

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

        // GET: CourseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CourseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: CourseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: CourseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CourseController/Delete/5
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
