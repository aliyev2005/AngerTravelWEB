using AngerTravelWEB.Data;
using Microsoft.AspNetCore.Mvc;
using AngerTravelWEB.Models;
namespace AngerTravelWEB.Controllers
{
    public class BlogController : Controller
    {
        private readonly AngerDbContext _context;
        public BlogController(AngerDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = _context.Blogs.ToList();
            return View(model);
        }
    }
}
