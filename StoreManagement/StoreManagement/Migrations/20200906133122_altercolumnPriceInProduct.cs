using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreManagement.Migrations
{
    public partial class altercolumnPriceInProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantityPerUnit",
                table: "Products");

            migrationBuilder.AddColumn<double>(
                name: "PricePerUnit",
                table: "Products",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PricePerUnit",
                table: "Products");

            migrationBuilder.AddColumn<double>(
                name: "QuantityPerUnit",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
