using AngerTravelWEB.Data;
using AngerTravelWEB.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AngerTravelWEB.Controllers
{
    public class Package : Controller
    {
        private readonly AngerDbContext _context;
        public Package(AngerDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            PackageVm model = new PackageVm()
            {
                partners = _context.partners.ToList(),
                Feedbacks = _context.Feedbacks.ToList(),
                Packages = _context.Packages.ToList(),
            };
            return View(model);
        }
    }
}
