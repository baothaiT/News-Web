using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.Data;
using News.Entities;
using System;
using System.Security.Claims;

namespace News.Controllers.Staff
{
    public class CommentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CommentController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: CommentController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CommentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CommentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CommentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Comments comments)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //Get Informaion 
                    string namePc = Environment.MachineName;
                    bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();
                    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                    var createComment = new Comments()
                    {
                        cmt_Id = Guid.NewGuid().ToString(),
                        cmt_Content = comments.cmt_Content,
                        cmt_UserId = userId,
                        cmt_UpdateDate = DateTime.Now,
                        cmt_IdeaId = comments.cmt_IdeaId,
                        cmt_IsDelete = false
                    };

                    _context.Comments.Add(createComment);
                    _context.SaveChanges();
                }

                return Redirect("/blogsingle?id="+ comments.cmt_IdeaId);
            }
            catch
            {
                return View();
            }
        }

        // GET: CommentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CommentController/Edit/5
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

        // GET: CommentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CommentController/Delete/5
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
