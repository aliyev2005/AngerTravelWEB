using System.ComponentModel.DataAnnotations.Schema;

namespace AngerTravelWEB.Models
{
    public class Blog : BaseEntities
    {
        public string Title  { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public DateTime AddedDate { get; set; }
        //Category
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        //User
        public int UserId { get; set; }
        public User user { get; set; }
        //Comment

        public List<Comment> Comments { get; set;}
    }
}
