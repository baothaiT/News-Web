using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.Data;
using News.Entities;
using System;

namespace News.Controllers.Coordinator
{
    public class AcademicYearManagementController : Controller
    {
        private ApplicationDbContext _context;
        public AcademicYearManagementController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: AcademicYearController
        [Route("submissionmanagement")]
        public ActionResult Index()
        {
            var query = _context.Submission;
            return View(query);
        }

        // GET: AcademicYearController/Details/5
        [Route("submissionmanagement/details")]
        [HttpGet]
        public ActionResult Details(string id)
        {
            var query = _context.Submission.Find(id);
            return View(query);
        }

        // GET: AcademicYearController/Create
        [Route("submissionmanagement/create")]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: AcademicYearController/Create
        [Route("submissionmanagement/create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Submission submission )
        {
            try
            {

                var newSubmission = new Submission()
                {
                    submission_Id = Guid.NewGuid().ToString(),
                    submission_Name = submission.submission_Name,
                    submission_Description = submission.submission_Description,
                    submission_StartTime = submission.submission_StartTime,
                    submission_DueTime = submission.submission_DueTime
                };

                _context.Submission.Add(newSubmission);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AcademicYearController/Edit/5
        [Route("submissionmanagement/edit")]
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var query = _context.Submission.Find(id);
            return View(query);
        }

        // POST: AcademicYearController/Edit/5
        [Route("submissionmanagement/edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Submission submission)
        {
            try
            {
                var query = _context.Submission.Find(submission.submission_Id);

                query.submission_Name = submission.submission_Name;
                query.submission_Description = submission.submission_Description;
                query.submission_StartTime = submission.submission_StartTime;
                query.submission_DueTime = submission.submission_DueTime;

                _context.Submission.Update(query);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AcademicYearController/Delete/5
        [Route("academicyearmanagement/delete")]
        [HttpGet]
        public ActionResult Delete(string id)
        {
            //var query = _context.AcademicYear.Find(id);
            return View();
        }

        // POST: AcademicYearController/Delete/5
        [Route("academicyearmanagement/delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, Submission academicYear)
        {
            try
            {
                //var query = _context.AcademicYear.Find(academicYear.academicYear_Id);
                //_context.AcademicYear.Remove(query);
                //_context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
