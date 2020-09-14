using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreManagement.Migrations
{
    public partial class SeedataNoCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91",
                column: "ConcurrencyStamp",
                value: "b26b3209-2b76-475c-89f0-71b7a7740ed7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "5d405e72-7f4b-4472-9237-f4f80a567c63", "AQAAAAEAACcQAAAAENx6nNEw3LZjelBwAF3zHqd+0CRFN+mnp2PqaPRqtRLwssnOUtaXdBD0Ih+sPi/NbQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC876771-8301-4765-B037-859AA899D708",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "7a68928d-7131-4c69-b3a6-43c2711b09ac", "AQAAAAEAACcQAAAAEOTKnA+HshTsTbZN5xqAM3w6waFsRMVxRJSDfKoydYtOawg2Cb+a6ZvQ85ecyddIHA==" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "CreateBy", "Name", "Status" },
                values: new object[] { 4, new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "No Category", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "default_product_image.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "default_product_image.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "default_product_image.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "default_product_image.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagePath",
                value: "default_product_image.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImagePath",
                value: "default_product_image.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImagePath",
                value: "default_product_image.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91",
                column: "ConcurrencyStamp",
                value: "df2ab4b2-9eda-4d71-a317-6f074bcdf8b9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "d294327f-c4ce-4416-8dee-06b5918b9c0f", "AQAAAAEAACcQAAAAEEjH3lCpckKZqcFNApZn8402AW07nO2xAdVRu4r6R0OoKNTfiCMLbucwjKA3AV7IaA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC876771-8301-4765-B037-859AA899D708",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "8a8243dd-9ca2-4b89-b855-7f2215feefda", "AQAAAAEAACcQAAAAEKX4u0m4i4VOfkVHtb+qN26P++VcxGAiHQduFN5xwhpWmh59HAqvOvEQNqK+Lm8TXg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "default_product_image.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "default_product_image.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "default_product_image.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "default_product_image.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagePath",
                value: "default_product_image.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImagePath",
                value: "default_product_image.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImagePath",
                value: "default_product_image.png");
        }
    }
}
