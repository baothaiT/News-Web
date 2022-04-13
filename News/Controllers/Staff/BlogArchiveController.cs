﻿using Food.Service;
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
            if (submissionId != null)
            {
                query = query.Where(a => a.idea_SubmissionId == submissionId);
            }

            query = query.OrderByDescending(s => s.idea_UpdateTime);
            if (typeSort != "")
            {
                switch (typeSort)
                {
                    case "MostView":
                        // code block
                        query = query.OrderByDescending(s => s.idea_View);
                        break;
                    case "Popular":
                        // code block
                        query = query.OrderByDescending(s => s.idea_View);
                        break;
                    default:
                        // code block
                        break;
                }
            }
            

            //Create Idea
            var blogModelQuery = query
                .Select(x => new BlogArchiveModels()
                {
                    Id = x.idea_Id,
                    Title = x.idea_Title,
                    Img = x.idea_ImageName,
                    UserName = "",
                    CountComment = 20,
                    ShortDescription = "",
                    UpdateTime = x.idea_UpdateTime

                });
            int pageSize = 2;
            return View(PaginatedList<BlogArchiveModels>.Create(blogModelQuery.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: BlogArchiveController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BlogArchiveController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogArchiveController/Create
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

        // GET: BlogArchiveController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlogArchiveController/Edit/5
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

        // GET: BlogArchiveController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlogArchiveController/Delete/5
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
