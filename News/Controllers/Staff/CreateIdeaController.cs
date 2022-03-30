using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace News.Controllers.Staff
{
    public class CreateIdeaController : Controller
    {
        // GET: CreateIdeaController
        [Route("createiead")]
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
        public ActionResult Create()
        {
            return View();
        }

        // POST: CreateIdeaController/Create
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
    }
}
