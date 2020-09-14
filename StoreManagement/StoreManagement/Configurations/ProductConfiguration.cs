using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreManagement.Models.Entities;

namespace StoreManagement.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();

            builder.Property(x => x.ImagePath).HasMaxLength(200)
                .IsRequired(false)
                .HasDefaultValue("default_product_image.png");

            builder.Property(x => x.CategoryId).IsRequired();

            builder.HasOne(p => p.ApplicationUser)
                .WithMany(b => b.Products)
                .HasForeignKey(p => p.CreateBy)
                .IsRequired(false);
        }
    }
}
