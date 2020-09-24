using Microsoft.EntityFrameworkCore;
using SchoolManagement_ThiModul3.Configurations;
using SchoolManagement_ThiModul3.Extensions;
using SchoolManagement_ThiModul3.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement_ThiModul3.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<Student> Students { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new ClassRoomConfiguration());

            //seeData
            modelBuilder.Seed();
        }
    }
}
