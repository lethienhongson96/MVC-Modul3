using Microsoft.EntityFrameworkCore.Migrations;

namespace ToKhaiYTe.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceId = table.Column<int>(nullable: false),
                    DistrictId = table.Column<int>(nullable: false),
                    WardId = table.Column<int>(nullable: false),
                    HouseNum = table.Column<string>(nullable: true),
                    PhoneNum = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "days",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    day = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_days", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "district",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    _name = table.Column<string>(maxLength: 100, nullable: true),
                    _prefix = table.Column<string>(maxLength: 20, nullable: true),
                    _province_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "gates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GateName = table.Column<string>(maxLength: 50, nullable: false),
                    IsPublished = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LichSuPhoiNhiems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TiepXucDongVat = table.Column<bool>(nullable: false),
                    TiepXucNguoiNhiem = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuPhoiNhiems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "months",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    month = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_months", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "province",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    _name = table.Column<string>(maxLength: 50, nullable: true),
                    _code = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Symptoms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sot = table.Column<bool>(nullable: false),
                    Ho = table.Column<bool>(nullable: false),
                    KhoTho = table.Column<bool>(nullable: false),
                    DauHong = table.Column<bool>(nullable: false),
                    BuonNon = table.Column<bool>(nullable: false),
                    TieuChay = table.Column<bool>(nullable: false),
                    XuatHuyetNgoaiDa = table.Column<bool>(nullable: false),
                    NoiBanNgoaiDa = table.Column<bool>(nullable: false),
                    VacxinDaSuDung = table.Column<string>(nullable: true),
                    LichSuPhoiNhiemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symptoms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TravelInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Airplane = table.Column<bool>(nullable: false),
                    Ships = table.Column<bool>(nullable: false),
                    Car = table.Column<bool>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    VehicleNum = table.Column<string>(nullable: true),
                    DepartureDateId = table.Column<int>(nullable: false),
                    EntryDateId = table.Column<int>(nullable: false),
                    SeatNum = table.Column<string>(nullable: true),
                    DepartureProvinceId = table.Column<int>(nullable: false),
                    EntryProvinceId = table.Column<int>(nullable: false),
                    RecentInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ward",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    _name = table.Column<string>(maxLength: 50, nullable: false),
                    _prefix = table.Column<string>(maxLength: 20, nullable: true),
                    _province_id = table.Column<int>(nullable: true),
                    _district_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "years",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_years", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalForms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Passport = table.Column<string>(nullable: true),
                    GatesId = table.Column<int>(nullable: false),
                    YearOfBirthId = table.Column<int>(nullable: false),
                    TravelInfoId = table.Column<int>(nullable: false),
                    ContactId = table.Column<int>(nullable: false),
                    SymptomId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalForms_gates_GatesId",
                        column: x => x.GatesId,
                        principalTable: "gates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalForms_Symptoms_SymptomId",
                        column: x => x.SymptomId,
                        principalTable: "Symptoms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalForms_TravelInfos_TravelInfoId",
                        column: x => x.TravelInfoId,
                        principalTable: "TravelInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalForms_GatesId",
                table: "MedicalForms",
                column: "GatesId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalForms_SymptomId",
                table: "MedicalForms",
                column: "SymptomId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalForms_TravelInfoId",
                table: "MedicalForms",
                column: "TravelInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "days");

            migrationBuilder.DropTable(
                name: "district");

            migrationBuilder.DropTable(
                name: "LichSuPhoiNhiems");

            migrationBuilder.DropTable(
                name: "MedicalForms");

            migrationBuilder.DropTable(
                name: "months");

            migrationBuilder.DropTable(
                name: "province");

            migrationBuilder.DropTable(
                name: "ward");

            migrationBuilder.DropTable(
                name: "years");

            migrationBuilder.DropTable(
                name: "gates");

            migrationBuilder.DropTable(
                name: "Symptoms");

            migrationBuilder.DropTable(
                name: "TravelInfos");
        }
    }
}
