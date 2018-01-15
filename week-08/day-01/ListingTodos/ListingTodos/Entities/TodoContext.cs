using Microsoft.EntityFrameworkCore;

namespace ListingTodos.Entities
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Todo> Todos { get; set; }
    }
}
