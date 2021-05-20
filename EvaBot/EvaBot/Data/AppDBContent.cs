using EvaBot.Data.Models;
using EvaBot.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvaBot.Data
{
    public class AppDBContent : DbContext
    {



        public AppDBContent(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Car> car { get; set; }
        public DbSet<Category> category { get; set; }
    }
}

