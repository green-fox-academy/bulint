using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using RedditMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
