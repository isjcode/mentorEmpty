using mentorEmpty.DAL;
using mentorEmpty.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace mentorEmpty.Controllers
{
    public class TrainersController : Controller
    {
        public readonly AppDbContext _context;


        public TrainersController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Trainers> trainers = _context.Trainers.Include(x=>x.Positions).ToList();
            return View(trainers);
        }
        
    }
}
