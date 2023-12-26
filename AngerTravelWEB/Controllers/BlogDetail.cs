using AngerTravelWEB.Data;
using Microsoft.AspNetCore.Mvc;

namespace AngerTravelWEB.Controllers
{
    public class BlogDetail : Controller
    {
        private readonly AngerDbContext _context;
        public BlogDetail(AngerDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = _context.Categories.ToList();
            return View(model);
        }
    }
}
