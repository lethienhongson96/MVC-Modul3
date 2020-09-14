using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreManagement.Migrations
{
    public partial class ImageDefaultForUserAndProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Products",
                maxLength: 200,
                nullable: true,
                defaultValue: "default_product_image.png",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Avatar",
                table: "AspNetUsers",
                maxLength: 200,
                nullable: true,
                defaultValue: "DefaultAvatar.png",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Products",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValue: "default_product_image.png");

            migrationBuilder.AlterColumn<string>(
                name: "Avatar",
                table: "AspNetUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValue: "DefaultAvatar.png");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91",
                column: "ConcurrencyStamp",
                value: "ed3df663-b6a9-4141-a6b6-c2f31897ff4e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc208b3d-637a-433d-a6e4-9ad73f760cf6", "AQAAAAEAACcQAAAAEPDalxwiZpkABqkAcJpDOVpDYkpHc4CoJLr7Veb2OH0Al6qJMGbGKVa2JRHRfJtfmg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC876771-8301-4765-B037-859AA899D708",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f207c88-e1a7-4bee-9dd2-4e4e08487f8b", "AQAAAAEAACcQAAAAEFsB52XMC886qcqoAyauqo1jr61a7bRjQ9lgAl64Oig/Lf1ObWjFwATfCjyKxBMDhw==" });
        }
    }
}
