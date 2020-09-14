using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StoreManagement.Configurations;
using StoreManagement.Extensions;
using StoreManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Models
{
    public class StoreDbContext : IdentityDbContext<ApplicationUser>
    {
        public StoreDbContext()
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<OrderDetail> OrderDetails{ get; set; }

        //Address for Account
        public DbSet<District> District { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<Ward> Ward { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=.\\SQLexpress;Database=StoreDb;Trusted_Connection=True;");
        }

        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());

            //config Address 
            modelBuilder.ApplyConfiguration(new ProvinceConfiguration());
            modelBuilder.ApplyConfiguration(new DistrictConfiguration());
            modelBuilder.ApplyConfiguration(new WardConfiguration());

            //seeding data
            modelBuilder.Seed();
        }

    }
}
