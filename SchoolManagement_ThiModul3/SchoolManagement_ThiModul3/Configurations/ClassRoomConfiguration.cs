using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagement_ThiModul3.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement_ThiModul3.Configurations
{
    public class ClassRoomConfiguration : IEntityTypeConfiguration<ClassRoom>
    {
        public void Configure(EntityTypeBuilder<ClassRoom> builder)
        {
            builder.Property(el => el.ClassName).IsRequired().HasMaxLength(50);
        }
    }
}
