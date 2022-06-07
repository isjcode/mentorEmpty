using mentorEmpty.DAL;
using mentorEmpty.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace mentorEmpty.Controllers
{
    public class EventsController : Controller
    {
        public readonly AppDbContext _context;


        public EventsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Events> events = _context.Events.ToList();
            return View(events);
        }
    }
}
