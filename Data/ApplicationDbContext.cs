using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProductOrdering.Models;

namespace ProductOrdering.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Province> Provinces { get; set; }
        public DbSet<geography> Geographies { get; set; }
        public DbSet<Aumphure> Aumphures { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Ordering> Orderings { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<Receiver> Receivers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
