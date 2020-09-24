using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagement_ThiModul3.Migrations
{
    public partial class SeeDataForClassRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "Id", "ClassName" },
                values: new object[,]
                {
                    { 1, "C05" },
                    { 2, "C06" },
                    { 3, "C07" },
                    { 4, "C08" },
                    { 5, "C09" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
