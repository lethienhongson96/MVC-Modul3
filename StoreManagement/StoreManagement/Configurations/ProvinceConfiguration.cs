using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Configurations
{
    public class ProvinceConfiguration : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.HasNoKey();

            builder.ToTable("province");

            builder.Property(e => e.Code)
                    .HasColumnName("_code")
                    .HasMaxLength(20);

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Name)
                    .HasColumnName("_name")
                    .HasMaxLength(50);
        }
    }
}
