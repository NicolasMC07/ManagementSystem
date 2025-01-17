using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementSystem.Models;
using ManagementSystem.Seeders;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Data
{

    public class AppDbContext : DbContext
    {
        //Tables
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Model creating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            CategorySeeder.Seed(modelBuilder);
            ProductSeeder.Seed(modelBuilder);

        }

    }

}