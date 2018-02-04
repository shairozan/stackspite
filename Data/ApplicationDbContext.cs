using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using stackspite.Models;

namespace stackspite.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Firewall> Firewalls {get; set;}
        public DbSet<FirewallGroup> FirewallGroups {get; set;}
        public DbSet<Router> Routers {get; set;}
        public DbSet<RouterGroup> RouterGroups {get; set;}
        public DbSet<Switch> Switches {get; set;}
        public DbSet<SwitchGroup> SwitchGroups {get; set;}
        public DbSet<Location> Locations {get; set;}
        public DbSet<Manufacturer> Manufacturers {get; set;}
        public DbSet<Make> Makes {get; set;}
        public DbSet<HierarchyLayer> HierarchyLayer {get; set;}
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@Environment.GetEnvironmentVariable("MYSQL_CONNECTION_STRING"));

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
