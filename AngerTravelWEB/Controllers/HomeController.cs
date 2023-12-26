using AngerTravelWEB.Data;
using AngerTravelWEB.Models;
using AngerTravelWEB.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AngerTravelWEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly AngerDbContext _context;
        public HomeController(AngerDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVm vm = new HomeVm()
            {
                Choose = _context.Choose.First(),
                services = _context.Services.ToList(),
                packages = _context.Packages.ToList(),
                gallerys = _context.Galleries.ToList(),
                feedbacks = _context.Feedbacks.ToList(),
                blogs = _context.Blogs.ToList(),
                partner = _context.partners.ToList(),
            };
            return View(vm);
        }
    }
}
