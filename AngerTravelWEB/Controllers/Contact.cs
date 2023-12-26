using AngerTravelWEB.Data;
using AngerTravelWEB.Models;
using AngerTravelWEB.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AngerTravelWEB.Controllers
{
    public class Contact : Controller
    {
        private readonly AngerDbContext _context;
        public Contact(AngerDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ContactVm contactVm = new ContactVm()
            {
                feedbacks = _context.Feedbacks.ToList(),
                Partner = _context.partners.ToList(),
                Contacts = _context.Contacts.First(),
                
            };
            
            return View(contactVm);
        }
    }
}
