using System.ComponentModel.DataAnnotations.Schema;

namespace AngerTravelWEB.Models
{
    public class Comment:BaseEntities
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public Blog Blogs { get; set; }
        
    }
}
