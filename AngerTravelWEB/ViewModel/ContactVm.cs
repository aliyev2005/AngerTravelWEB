using AngerTravelWEB.Models;

namespace AngerTravelWEB.ViewModel
{
	public class ContactVm
	{
		public Contact Contacts { get; set; }
		public List<Partners> Partner { get; set; }
		public List<Feedback> feedbacks { get; set; }

	}
}
