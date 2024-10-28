using Akademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Akademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }

        public IActionResult Apply() //get
        {
            return View();
        }

        [HttpPost] //POST
        [ValidateAntiForgeryToken] //for security
         public IActionResult Apply([FromForm]Candidate model) //data from form
        {
            Repository.Add(model);
            return View("FeedBack", model);
        }

    }
}