using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreManagement.Migrations
{
    public partial class DropProvincDistrictWard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Wards");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _prefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _province_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Wards",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _district_id = table.Column<int>(type: "int", nullable: false),
                    _name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _prefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _province_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wards", x => x.id);
                });
        }
    }
}
