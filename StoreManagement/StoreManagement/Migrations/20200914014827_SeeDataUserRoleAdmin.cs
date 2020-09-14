using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreManagement.Migrations
{
    public partial class SeeDataUserRoleAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "ApplicationUserId", "DistrictId", "HouseNum", "ProvinceId", "WardId" },
                values: new object[] { 1, null, 194, "28 Nguyễn Tri Phương", 15, 2724 });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91", "76707d0f-2f6b-48e2-9576-c4529890efdb", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "CE6654BD-705E-4D25-8C90-71E2654ADAE8", 0, 1, null, "7eaaac3d-b324-494a-a73a-d9f48e4313b8", "lethienhongson96@gmail.com", true, "Hồng Sơn", false, null, "lethienhongson96@gmail.com", "lethienhongson96@gmail.com", "AQAAAAEAACcQAAAAEIpmMi6xtL4qrhTzHnfpXgvUWhndFCCbnfFpLxwcu8p8vo8/r1yibCZh24Da9BTC5g==", null, false, "", false, "lethienhongson96@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "CreateBy", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 9, 14, 8, 48, 26, 968, DateTimeKind.Local).AddTicks(6611), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "Iphone", 1 },
                    { 2, new DateTime(2020, 9, 14, 8, 48, 26, 969, DateTimeKind.Local).AddTicks(5178), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "SamSung", 1 },
                    { 3, new DateTime(2020, 9, 14, 8, 48, 26, 969, DateTimeKind.Local).AddTicks(5209), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "Bphone", 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateAt", "CreateBy", "ImagePath", "Name", "PricePerUnit", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 9, 14, 8, 48, 26, 969, DateTimeKind.Local).AddTicks(7329), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "default_product_image", "Iphone 5", 5000000.0, 1 },
                    { 2, 1, new DateTime(2020, 9, 14, 8, 48, 26, 969, DateTimeKind.Local).AddTicks(9190), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "default_product_image", "Iphone 6", 6000000.0, 1 },
                    { 3, 1, new DateTime(2020, 9, 14, 8, 48, 26, 969, DateTimeKind.Local).AddTicks(9235), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "default_product_image", "Iphone 7", 7000000.0, 1 },
                    { 4, 2, new DateTime(2020, 9, 14, 8, 48, 26, 969, DateTimeKind.Local).AddTicks(9237), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "default_product_image", "Galaxy 3", 3000000.0, 1 },
                    { 5, 2, new DateTime(2020, 9, 14, 8, 48, 26, 969, DateTimeKind.Local).AddTicks(9238), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "default_product_image", "Galaxy 4", 4000000.0, 1 },
                    { 6, 3, new DateTime(2020, 9, 14, 8, 48, 26, 969, DateTimeKind.Local).AddTicks(9240), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "default_product_image", "BPhone 10", 10000000.0, 1 },
                    { 7, 3, new DateTime(2020, 9, 14, 8, 48, 26, 969, DateTimeKind.Local).AddTicks(9241), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "default_product_image", "BPhone 11", 11000000.0, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91" });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8");
        }
    }
}
