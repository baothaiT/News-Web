using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace News.Controllers.Staff
{
    public class CourseDetailController : Controller
    {
        // GET: CourseDetailController
        [Route("coursedetail")]
        public ActionResult Index()
        {
            return View();
        }


    }
}
