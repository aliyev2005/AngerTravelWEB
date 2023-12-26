using AngerTravelWEB.Models;
using Microsoft.EntityFrameworkCore;

namespace AngerTravelWEB.Data
{
    public class AngerDbContext:DbContext
    {
        public AngerDbContext(DbContextOptions<AngerDbContext> options):base(options)
        {
            
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ChooseUs> Choose { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Partners> partners { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }

    }
}
