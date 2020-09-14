using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StoreManagement.Models;
using StoreManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().HasData(new Address
            {
                Id = 1,
                ProvinceId = 15,
                DistrictId = 194,
                WardId = 2724,
                HouseNum = "28 Nguyễn Tri Phương"
            });

            const string ADMIN_ID = "CE6654BD-705E-4D25-8C90-71E2654ADAE8";
            // any guid, but nothing is against to use the same one
            const string ROLE_ID = "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91";
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = ROLE_ID,
                Name = "Admin",
                NormalizedName = "Admin"
            });

            var hasher = new PasswordHasher<ApplicationUser>();
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = ADMIN_ID,
                UserName = "lethienhongson96@gmail.com",
                NormalizedUserName = "lethienhongson96@gmail.com",
                Email = "lethienhongson96@gmail.com",
                NormalizedEmail = "lethienhongson96@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Asdf123!"),
                SecurityStamp = string.Empty,
                FullName = "Hồng Sơn",
                AddressId = 1,
                Avatar = "DefaultAvatar.png",
                PhoneNumber="0982102073"
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });

            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Iphone", Status = Enum.Status.Active, CreateAt = DateTime.Today, CreateBy = ADMIN_ID },
            new Category { Id = 2, Name = "SamSung", Status = Enum.Status.Active, CreateAt = DateTime.Today, CreateBy = ADMIN_ID },
            new Category { Id = 3, Name = "Bphone", Status = Enum.Status.Active, CreateAt = DateTime.Today, CreateBy = ADMIN_ID },
            new Category { Id = 4, Name = "No Category", Status = Enum.Status.Active, CreateAt = DateTime.Today, CreateBy = ADMIN_ID }
            );

            #region Create Product
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Iphone 5",
                    PricePerUnit = 5000000,
                    CreateAt = DateTime.Today,
                    ImagePath = "default_product_image.png",
                    Status = Enum.Status.Active,
                    CategoryId = 1,
                    CreateBy = ADMIN_ID
                },
                new Product
                {
                    Id = 2,
                    Name = "Iphone 6",
                    PricePerUnit = 6000000,
                    CreateAt = DateTime.Today,
                    ImagePath = "default_product_image.png",
                    Status = Enum.Status.Active,
                    CategoryId = 1,
                    CreateBy = ADMIN_ID
                },
                new Product
                {
                    Id = 3,
                    Name = "Iphone 7",
                    PricePerUnit = 7000000,
                    CreateAt = DateTime.Today,
                    ImagePath = "default_product_image.png",
                    Status = Enum.Status.Active,
                    CategoryId = 1,
                    CreateBy = ADMIN_ID
                },
                new Product
                {
                    Id = 4,
                    Name = "Galaxy 3",
                    PricePerUnit = 3000000,
                    CreateAt = DateTime.Today,
                    ImagePath = "default_product_image.png",
                    Status = Enum.Status.Active,
                    CategoryId = 2,
                    CreateBy = ADMIN_ID
                },
                new Product
                {
                    Id = 5,
                    Name = "Galaxy 4",
                    PricePerUnit = 4000000,
                    CreateAt = DateTime.Today,
                    ImagePath = "default_product_image.png",
                    Status = Enum.Status.Active,
                    CategoryId = 2,
                    CreateBy = ADMIN_ID
                },
                new Product
                {
                    Id = 6,
                    Name = "BPhone 10",
                    PricePerUnit = 10000000,
                    CreateAt = DateTime.Today,
                    ImagePath = "default_product_image.png",
                    Status = Enum.Status.Active,
                    CategoryId = 3,
                    CreateBy = ADMIN_ID
                },
                new Product
                {
                    Id = 7,
                    Name = "BPhone 11",
                    PricePerUnit = 11000000,
                    CreateAt = DateTime.Today,
                    ImagePath = "default_product_image.png",
                    Status = Enum.Status.Active,
                    CategoryId = 3,
                    CreateBy = ADMIN_ID
                }
                );
            #endregion

            modelBuilder.Entity<Address>().HasData(new Address
            {
                Id = 2,
                ProvinceId = 15,
                DistrictId = 194,
                WardId = 2724,
                HouseNum = "28 Nguyễn Tri Phương"
            });

            var CustomerId = "FC876771-8301-4765-B037-859AA899D708";
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = CustomerId,
                UserName = "Customer@gmail.com",
                NormalizedUserName = "Customer@gmail.com",
                Email = "Customer@gmail.com",
                NormalizedEmail = "Customer@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Asdf123!"),
                SecurityStamp = string.Empty,
                FullName = "Nguyễn Văn Vui",
                AddressId = 2,
                Avatar = "DefaultAvatar.png",
                PhoneNumber = "0984910724"
            });

            #region Create Order and OrderDetail
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    PayStatus = Enum.PayStatus.unpaid,
                    CreateAt = DateTime.Today,
                    ShipperDate = DateTime.Today,
                    ApplicationUserId = CustomerId
                },
                new Order
                {
                    Id = 2,
                    PayStatus = Enum.PayStatus.unpaid,
                    CreateAt = DateTime.Today,
                    ShipperDate = DateTime.Today,
                    ApplicationUserId = CustomerId
                },
                new Order
                {
                    Id = 3,
                    PayStatus = Enum.PayStatus.unpaid,
                    CreateAt = DateTime.Today,
                    ShipperDate = DateTime.Today,
                    ApplicationUserId = CustomerId
                });

            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail { OrderId = 1, ProductId = 1, Quantity = 1, UnitPrice = 5000000, PayStatus = Enum.PayStatus.unpaid },
                new OrderDetail { OrderId = 1, ProductId = 2, Quantity = 2, UnitPrice = 12000000, PayStatus = Enum.PayStatus.unpaid },
                new OrderDetail { OrderId = 2, ProductId = 3, Quantity = 1, UnitPrice = 7000000, PayStatus = Enum.PayStatus.unpaid },
                new OrderDetail { OrderId = 2, ProductId = 4, Quantity = 3, UnitPrice = 9000000, PayStatus = Enum.PayStatus.unpaid },
                new OrderDetail { OrderId = 3, ProductId = 5, Quantity = 1, UnitPrice = 4000000, PayStatus = Enum.PayStatus.unpaid },
                new OrderDetail { OrderId = 3, ProductId = 6, Quantity = 2, UnitPrice = 20000000, PayStatus = Enum.PayStatus.unpaid }
                );
            #endregion
        }
    }
}
