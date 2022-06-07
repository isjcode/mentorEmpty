using mentorEmpty.DAL;
using mentorEmpty.Models;
using mentorEmpty.ViewModels;
using mentorEmpty.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace mentorEmpty.Controllers
{
    public class PricingController : Controller
    {
        public readonly AppDbContext _context;


        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            PricingVM pricingVM = new PricingVM
            {
                Pricing = _context.Pricing.Include(x => x.Join).ThenInclude(x => x.Features).ToList(),
                Features = _context.Features.Include(x => x.Join).ThenInclude(x => x.Pricing).ToList()

            };
            return View(pricingVM);
        }
    }
}
