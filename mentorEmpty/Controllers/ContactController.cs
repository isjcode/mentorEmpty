using Microsoft.AspNetCore.Mvc;

namespace mentorEmpty.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
