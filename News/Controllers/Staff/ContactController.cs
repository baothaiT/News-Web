using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.Data;
using News.Entities;
using System;

namespace News.Controllers.Staff
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: ContactController
        [Route("/contact")]
        public ActionResult Index()
        {
            //Class active
            ViewBag.ContactActive = "active";

            return View();
        }



        // POST: ContactController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContactEmail contactEmail)
        {
            try
            {
                //Create New contact 
                var createContact = new ContactEmail()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = contactEmail.Name,
                    Email = contactEmail.Email,
                    Subject = contactEmail.Subject,
                    Message = contactEmail.Message
                };

                _context.ContactEmail.Add(createContact);
                _context.SaveChanges();

                return Redirect("/");
            }
            catch
            {
                return Redirect("/");
            }
        }

       
    }
}
