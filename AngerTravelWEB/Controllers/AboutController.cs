using AngerTravelWEB.Data;
using AngerTravelWEB.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AngerTravelWEB.Controllers
{
    public class AboutController : Controller
    {
        private readonly AngerDbContext _context;
        public AboutController(AngerDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            AboutVm model = new AboutVm()
            {
                about = _context.Abouts.First(),
                choose = _context.Choose.First(),
                part = _context.partners.ToList(),
                feedbacks = _context.Feedbacks.ToList(),
            };
            return View(model);
        }
    }
}
