using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagement_ThiModul3.Migrations
{
    public partial class CreateRelationShipForStudentandClassRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassRoomId",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassRoomId",
                table: "Students",
                column: "ClassRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_ClassRooms_ClassRoomId",
                table: "Students",
                column: "ClassRoomId",
                principalTable: "ClassRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_ClassRooms_ClassRoomId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ClassRoomId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ClassRoomId",
                table: "Students");
        }
    }
}
