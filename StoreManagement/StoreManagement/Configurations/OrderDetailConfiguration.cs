using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(bc => new { bc.OrderId, bc.ProductId });

            builder.HasOne(bc => bc.Order)
                .WithMany(b => b.OrderDetails)
                .HasForeignKey(bc => bc.OrderId);

            builder.HasOne(bc => bc.Product)
                .WithMany(c => c.OrderDetails)
                .HasForeignKey(bc => bc.ProductId);
        }
    }
}
