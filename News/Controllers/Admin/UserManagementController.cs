﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.Data;

namespace News.Controllers.Admin
{
    public class UserManagementController : Controller
    {
        private ApplicationDbContext _context;
        public UserManagementController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: UserManagementController
        [Route("usermanagement")]
        public ActionResult Index()
        {
            var query = _context.AppUser;
            return View(query);
        }

        // GET: UserManagementController/Details/5
        public ActionResult Details(string id)
        {
            return View();
        }

        // GET: UserManagementController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserManagementController/Create
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

        // GET: UserManagementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserManagementController/Edit/5
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

        // GET: UserManagementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserManagementController/Delete/5
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
