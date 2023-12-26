using AngerTravelWEB.Models;

namespace AngerTravelWEB.ViewModel
{
    public class AboutVm
    {
        public About about { get; set; }

        public ChooseUs choose { get; set; }
        public List<Partners> part { get; set; }
        public List<Feedback> feedbacks { get; set; }
    }
}
