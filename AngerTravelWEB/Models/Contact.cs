using System.ComponentModel.DataAnnotations;

namespace AngerTravelWEB.Models
{
    public class Contact:BaseEntities
    {
        public string Adress { get; set; }
        public string Phone { get; set; }
        [EmailAddress(ErrorMessage ="Input a true email")]
        public string Email { get; set; }
        public string Title { get; set; }
        public  string content { get; set; }
    }
}
