using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using News.Data;
using News.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace News.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.HomeActive = "active";
            //Start Query Idea
            var query = from a in _context.Idea select a;
            query = query.OrderByDescending(s => s.idea_UpdateTime);
            //End Query Idea


            //Create Idea
            var blogModelQuery = query
                .Select(x => new BlogArchiveModels()
                {
                    Id = x.idea_Id,
                    Title = x.idea_Title,
                    Img = x.idea_ImageName,
                    UserName = "",
                    CountComment = 20,
                    ShortDescription = x.idea_Description.Substring(0,50),
                    UpdateTime = x.idea_UpdateTime

                });

            ViewBag.IdeaList = blogModelQuery;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
