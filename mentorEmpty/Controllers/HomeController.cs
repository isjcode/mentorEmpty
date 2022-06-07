using Microsoft.AspNetCore.Mvc;

namespace mentorEmpty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
