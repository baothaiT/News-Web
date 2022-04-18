using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.Data;
using News.Entities;
using System;

namespace News.Controllers.Coordinator
{
    [Authorize(Roles = "Admin,Staff")]
    public class DepartmentManagementController : Controller
    {
        private ApplicationDbContext _context;
        public DepartmentManagementController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: DepartmentManagementController
        [Route("departmentmanagement")]
        public ActionResult Index()
        {
            var query = _context.Department;
            return View(query);
        }

        // GET: DepartmentManagementController/Details/5
        [Route("departmentmanagement/details")]
        [HttpGet]
        public ActionResult Details(string id)
        {
            var query = _context.Department.Find(id);
            return View(query);
        }

        // GET: DepartmentManagementController/Create
        [Route("departmentmanagement/create")]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentManagementController/Create
        [Route("departmentmanagement/create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Department department)
        {
            try
            {
                var newDepartment = new Department()
                {
                    department_Id = Guid.NewGuid().ToString(),
                    department_Name = department.department_Name,
                    department_Description = department.department_Description
                };

                _context.Department.Add(newDepartment);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentManagementController/Edit/5
        [Route("departmentmanagement/edit")]
        public ActionResult Edit(string id)
        {
            var query = _context.Department.Find(id);
            return View(query);
        }

        // POST: DepartmentManagementController/Edit/5
        [Route("departmentmanagement/edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Department department)
        {
            try
            {
                var query = _context.Department.Find(department.department_Id);
                query.department_Name = department.department_Name;
                query.department_Description = department.department_Description;

                _context.Department.Update(query);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentManagementController/Delete/5
        [Route("departmentmanagement/delete")]
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var query = _context.Department.Find(id);
            return View(query);
        }

        // POST: DepartmentManagementController/Delete/5
        [Route("departmentmanagement/delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, Department department)
        {
            try
            {
                var query = _context.Department.Find(department.department_Id);

                _context.Department.Remove(query);
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
