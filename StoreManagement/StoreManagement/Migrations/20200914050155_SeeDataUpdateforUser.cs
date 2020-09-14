using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreManagement.Migrations
{
    public partial class SeeDataUpdateforUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "dc208b3d-637a-433d-a6e4-9ad73f760cf6", "AQAAAAEAACcQAAAAEPDalxwiZpkABqkAcJpDOVpDYkpHc4CoJLr7Veb2OH0Al6qJMGbGKVa2JRHRfJtfmg==", "0982102073" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC876771-8301-4765-B037-859AA899D708",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "4f207c88-e1a7-4bee-9dd2-4e4e08487f8b", "AQAAAAEAACcQAAAAEFsB52XMC886qcqoAyauqo1jr61a7bRjQ9lgAl64Oig/Lf1ObWjFwATfCjyKxBMDhw==", "0984910724" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91",
                column: "ConcurrencyStamp",
                value: "80e56608-e12c-4890-9870-9e8e9fdf5478");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "ad0fd6cc-80b6-49f4-a932-ccf494e8dd3e", "AQAAAAEAACcQAAAAEBNW6y3INkKGbubE/W/G24Qh2BnOlBubIcD/QfdNvxaZFUCXR1ZGCvE90j89KzT53A==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC876771-8301-4765-B037-859AA899D708",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "73aeb7df-5e32-46bf-8968-5a571a00b95d", "AQAAAAEAACcQAAAAEL1J1aHb76pXavsgOqbSoC/Thq9wjUuzoQ1zFyYsv70g2NKSmZGv0k6ni0kSrQmdxw==", null });
        }
    }
}
