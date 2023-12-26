using System.Data.SqlTypes;

namespace AngerTravelWEB.Models
{
    public class User : BaseEntities
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
