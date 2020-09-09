using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StoreManagement.Configurations;
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

        //account management
        public DbSet<District> District { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<Ward> Ward { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLexpress;Database=StoreDb;Trusted_Connection=True;");
            }
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


            modelBuilder.Entity<District>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("district");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Prefix)
                    .HasColumnName("_prefix")
                    .HasMaxLength(20);

                entity.Property(e => e.ProvinceId).HasColumnName("_province_id");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("province");

                entity.Property(e => e.Code)
                    .HasColumnName("_code")
                    .HasMaxLength(20);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Ward>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ward");

                entity.Property(e => e.DistrictId).HasColumnName("_district_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Prefix)
                    .HasColumnName("_prefix")
                    .HasMaxLength(20);

                entity.Property(e => e.ProvinceId).HasColumnName("_province_id");
            });

        }

    }
}
