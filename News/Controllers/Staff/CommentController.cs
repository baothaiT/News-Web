using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
                        IsDelete = false
                    };

                    //Start Mail
                    // // Query AuthorId's idea
                    var queryUserId = _context.Idea.Find(comments.cmt_IdeaId);
                    // // Query Author's idea
                    var queryUser = _context.AppUser.Find(queryUserId.idea_UserId);

                    if(queryUser is not null)
                    {
                        SendMail(queryUser.Email, "Comment", "Success");
                    }
                    //End Mail

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
        public void SendMail(string Mailto, string subject, string boddy)
        {
            var smtpacountJson = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("MailSettings")["Mail"];
            var smtppasswordJson = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("MailSettings")["Password"];

            String mailgui = smtpacountJson.ToString();
            string smtpacount = smtpacountJson.ToString();
            string smtppassword = smtppasswordJson.ToString();

            MailUtils.MailUtils.SendMailGoogleSmtp(
                mailgui,
                Mailto,
                subject,
                boddy,
                smtpacount,
                smtppassword

            ).Wait();
        }
    }
}
