using mentorEmpty.DAL;
using mentorEmpty.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace mentorEmpty.Controllers
{
    public class CoursesController : Controller
    {
        public readonly AppDbContext _context;

        public CoursesController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Courses> courses = _context.Courses.Include(x => x.Position).ToList();
            return View(courses);
        }
    }
}
