using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using News.Data;
using News.Entities;
using News.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;


namespace News.Controllers.Staff
{
    public class CreateIdeaController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public CreateIdeaController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }
        // GET: CreateIdeaController

        public ActionResult Index()
        {
            //Class active
            ViewBag.UploadIdeaActive = "active";


            return View();
        }

        // GET: CreateIdeaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CreateIdeaController/Create
        [Route("createiead")]
        [HttpGet("submissionId")]
        public ActionResult Create(string submissionId)
        {
            //Class active
            ViewBag.UploadIdeaActive = "active";


            //Query Categories 
            var categoriesQuery = _context.Categories;

            List<SelectListItem> CategoryList = new List<SelectListItem>();
            foreach (var category in categoriesQuery)
            {
                var itemCategory = new SelectListItem { Value = category.category_Id, Text = category.category_Name };
                CategoryList.Add(itemCategory);
            }
            ViewBag.idea_CategoryId = CategoryList;

            //Query Academic Year 
            var SubmissionQuery = _context.Submission.Find(submissionId);

            List<SelectListItem> SubmissionList = new List<SelectListItem>();

            if (SubmissionQuery != null)
            {
                var itemSubmission = new SelectListItem { Value = SubmissionQuery.submission_Id, Text = SubmissionQuery.submission_Name };
                SubmissionList.Add(itemSubmission);
            }
               
            
            ViewBag.idea_submission_Name = SubmissionList;

            return View();
        }

        // POST: CreateIdeaController/Create
        [Route("createiead")]
        [HttpPost]
        public async Task<ActionResult> CreateAsync(IdeaModels idea)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(idea.idea_ImagePath.FileName);
                    string extension = Path.GetExtension(idea.idea_ImagePath.FileName);
                    fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Image/", fileName);
                    
                    //Create Idea
                    var createIdea = new Idea()
                    {
                        idea_Id = Guid.NewGuid().ToString(),
                        idea_Title = idea.idea_Title,
                        idea_Description = idea.idea_Description,
                        idea_ImagePath = path,
                        idea_ImageName = fileName ,
                        idea_UpdateTime = DateTime.Now,
                        idea_Agree = idea.idea_Agree,
                        idea_CategoryId = idea.idea_CategoryId,
                        idea_SubmissionId = idea.idea_SubmissionId,
                    };

                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await idea.idea_ImagePath.CopyToAsync(fileStream);
                    }
                    _context.Idea.Add(createIdea);
                    await _context.SaveChangesAsync();
                }

                return Redirect("/blogarchive");
            }
            catch
            {
                return View();
            }
        }

        // GET: CreateIdeaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CreateIdeaController/Edit/5
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

        // GET: CreateIdeaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CreateIdeaController/Delete/5
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
