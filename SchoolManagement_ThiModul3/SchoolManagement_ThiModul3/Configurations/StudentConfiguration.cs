using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagement_ThiModul3.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement_ThiModul3.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(el => el.Email).IsRequired().HasMaxLength(50);
            builder.Property(el => el.FullName).IsRequired().HasMaxLength(100);
            builder.Property(el => el.Gender).IsRequired().HasMaxLength(20);
        }
    }
}
