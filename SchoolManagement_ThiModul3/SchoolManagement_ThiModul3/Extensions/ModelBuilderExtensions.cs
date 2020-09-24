using Microsoft.EntityFrameworkCore;
using SchoolManagement_ThiModul3.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement_ThiModul3.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassRoom>().HasData(
                new ClassRoom { Id = 1, ClassName = "C05" },
                new ClassRoom { Id = 2, ClassName = "C06" },
                new ClassRoom { Id = 3, ClassName = "C07" },
                new ClassRoom { Id = 4, ClassName = "C08" },
                new ClassRoom { Id = 5, ClassName = "C09" }
                );

           /* modelBuilder.Entity<Student>().HasData(
                new Student { Id=1,FullName="Lê thiên hồng sơn",DoB=DateTime.Parse("27/11/1996")}
                );*/
        }
    }
}
