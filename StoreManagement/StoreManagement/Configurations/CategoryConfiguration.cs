using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.DependencyInjection;
using StoreManagement.Enum;
using StoreManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
             builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();

            builder.Property(x => x.Status).IsRequired().HasDefaultValue(Status.Active);

            builder.HasOne(p => p.ApplicationUser)
                .WithMany(b => b.Categories)
                .HasForeignKey(p => p.CreateBy);
        }
    }
}
