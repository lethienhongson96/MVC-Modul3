using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Configurations
{
    public class WardConfiguration : IEntityTypeConfiguration<Ward>
    {
        public void Configure(EntityTypeBuilder<Ward> builder)
        {
            builder.HasNoKey();

            builder.ToTable("ward");

            builder.Property(e => e.DistrictId).HasColumnName("_district_id");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("_name")
                    .HasMaxLength(50);

            builder.Property(e => e.Prefix)
                    .HasColumnName("_prefix")
                    .HasMaxLength(20);

            builder.Property(e => e.ProvinceId).HasColumnName("_province_id");
        }
    }
}
