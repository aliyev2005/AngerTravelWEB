using AngerTravelWEB.Data;
using AngerTravelWEB.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AngerTravelWEB.Controllers
{
    public class Galleri : Controller
    {
        private readonly AngerDbContext _context;
        public Galleri(AngerDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            GalleryVm vm = new GalleryVm()
            {
                partners = _context.partners.ToList(),
                galleries = _context.Galleries.ToList(),
                feedbacks = _context.Feedbacks.ToList(),

            };
            return View(vm);
        }
    }
}
