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
        [Route("academicyearmanagement")]
        public ActionResult Index()
        {
            var query = _context.AcademicYear;
            return View(query);
        }

        // GET: AcademicYearController/Details/5
        [Route("academicyearmanagement/details")]
        [HttpGet]
        public ActionResult Details(string id)
        {
            var query = _context.AcademicYear.Find(id);
            return View(query);
        }

        // GET: AcademicYearController/Create
        [Route("academicyearmanagement/create")]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: AcademicYearController/Create
        [Route("academicyearmanagement/create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AcademicYear academicYear )
        {
            try
            {

                var newAcademicYear = new AcademicYear()
                {
                    academicYear_Id = Guid.NewGuid().ToString(),
                    academicYear_Name = academicYear.academicYear_Name,
                    academicYear_Description = academicYear.academicYear_Description,
                    academicYear_StartTime = academicYear.academicYear_StartTime,
                    academicYear_DueTime = academicYear.academicYear_DueTime
                };

                _context.AcademicYear.Add(newAcademicYear);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AcademicYearController/Edit/5
        [Route("academicyearmanagement/edit")]
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var query = _context.AcademicYear.Find(id);
            return View(query);
        }

        // POST: AcademicYearController/Edit/5
        [Route("academicyearmanagement/edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, AcademicYear academicYear)
        {
            try
            {
                var query = _context.AcademicYear.Find(academicYear.academicYear_Id);

                query.academicYear_Name = academicYear.academicYear_Name;
                query.academicYear_Description = academicYear.academicYear_Description;
                query.academicYear_StartTime = academicYear.academicYear_StartTime;
                query.academicYear_DueTime= academicYear.academicYear_DueTime;

                _context.AcademicYear.Update(query);
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
            var query = _context.AcademicYear.Find(id);
            return View(query);
        }

        // POST: AcademicYearController/Delete/5
        [Route("academicyearmanagement/delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, AcademicYear academicYear)
        {
            try
            {
                var query = _context.AcademicYear.Find(academicYear.academicYear_Id);
                _context.AcademicYear.Remove(query);
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
