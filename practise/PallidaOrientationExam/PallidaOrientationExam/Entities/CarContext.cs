using Microsoft.EntityFrameworkCore;
using PallidaOrientationExam.Models;

namespace PallidaOrientationExam.Entities
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; } 
    }
}
