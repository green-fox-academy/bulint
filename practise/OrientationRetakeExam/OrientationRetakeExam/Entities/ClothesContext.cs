using Microsoft.EntityFrameworkCore;
using OrientationRetakeExam.Models;

namespace OrientationRetakeExam.Entities
{
    public class ClothesContext : DbContext
    {
        public ClothesContext(DbContextOptions options) : base(options)
        {

        }

        DbSet<Clothing> Clothes { get; set; }
    }
}
