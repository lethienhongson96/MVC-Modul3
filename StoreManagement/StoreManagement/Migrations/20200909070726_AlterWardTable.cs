using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreManagement.Migrations
{
    public partial class AlterWardTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wards_Provinces_Provinceid",
                table: "Wards");

            migrationBuilder.DropIndex(
                name: "IX_Wards_Provinceid",
                table: "Wards");

            migrationBuilder.DropColumn(
                name: "Provinceid",
                table: "Wards");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Provinceid",
                table: "Wards",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wards_Provinceid",
                table: "Wards",
                column: "Provinceid");

            migrationBuilder.AddForeignKey(
                name: "FK_Wards_Provinces_Provinceid",
                table: "Wards",
                column: "Provinceid",
                principalTable: "Provinces",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
