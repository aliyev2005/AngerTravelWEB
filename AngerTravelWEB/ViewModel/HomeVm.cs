using AngerTravelWEB.Models;

namespace AngerTravelWEB.ViewModel
{
    public class HomeVm
    {
        public ChooseUs Choose { get; set; }
        public List<Service> services { get; set; }
        public List<Package> packages { get; set; }
        public List<Gallery> gallerys { get; set; }
        public List<Feedback> feedbacks { get; set; }
        public List<Blog> blogs { get; set; }
        public List<Partners> partner { get; set; }
    }
}
