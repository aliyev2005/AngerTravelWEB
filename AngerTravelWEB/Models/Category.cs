namespace AngerTravelWEB.Models
{
    public class Category:BaseEntities
    {
        public string Name { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
