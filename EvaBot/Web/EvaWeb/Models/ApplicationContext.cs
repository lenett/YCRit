using EvaWeb.Areas.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace EvaWeb.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        //public DbSet<NavibarLink> NavibarLinks { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }

}

