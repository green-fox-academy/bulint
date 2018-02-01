using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using PallidaOrientationExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaOrientationExam.Entities
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Car> Cars { get; set; } 
    }
}
