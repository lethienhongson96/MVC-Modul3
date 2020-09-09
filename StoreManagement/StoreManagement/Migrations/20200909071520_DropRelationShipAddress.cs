using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreManagement.Migrations
{
    public partial class DropRelationShipAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Provinces__province_id",
                table: "Districts");

            migrationBuilder.DropForeignKey(
                name: "FK_Wards_Districts_Districtid",
                table: "Wards");

            migrationBuilder.DropIndex(
                name: "IX_Wards_Districtid",
                table: "Wards");

            migrationBuilder.DropIndex(
                name: "IX_Districts__province_id",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "Districtid",
                table: "Wards");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Districtid",
                table: "Wards",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wards_Districtid",
                table: "Wards",
                column: "Districtid");

            migrationBuilder.CreateIndex(
                name: "IX_Districts__province_id",
                table: "Districts",
                column: "_province_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Provinces__province_id",
                table: "Districts",
                column: "_province_id",
                principalTable: "Provinces",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wards_Districts_Districtid",
                table: "Wards",
                column: "Districtid",
                principalTable: "Districts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
