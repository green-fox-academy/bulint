using Microsoft.EntityFrameworkCore;
using RedditMan.Models;

namespace RedditMan.Entities
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Post> Reddit { get; set; }
    }
}
