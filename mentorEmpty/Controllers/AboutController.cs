using Microsoft.AspNetCore.Mvc;

namespace mentorEmpty.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
