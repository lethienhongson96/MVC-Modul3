using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreManagement.Migrations
{
    public partial class SeeDataForOrderAndOrderDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "ApplicationUserId", "DistrictId", "HouseNum", "ProvinceId", "WardId" },
                values: new object[] { 2, null, 194, "28 Nguyễn Tri Phương", 15, 2724 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91",
                column: "ConcurrencyStamp",
                value: "495d615c-16dc-4bc4-a8ce-2589a5489022");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar", "07c32e1e-0fdd-4a9d-ab05-7af026bbc75c", "AQAAAAEAACcQAAAAEDR8P2hx1vFczUxNiMP4SkIK1sSZFU48fbErySOtRETnBMf64OloeDeeN/cCTZWjbQ==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "FC876771-8301-4765-B037-859AA899D708", 0, 2, null, "29a34e46-5765-4d61-a482-da2ed7cdb36c", "Customer@gmail.com", true, "Nguyễn Văn Vui", false, null, "Customer@gmail.com", "Customer@gmail.com", "AQAAAAEAACcQAAAAEIfbxPVSB2RgrdDDDVKarAHVl1+51cTP3oHyhwgdQruL1tKFzRjV3pv1yw9xozTnTA==", null, false, "", false, "Customer@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ApplicationUserId", "CreateAt", "PayStatus", "ShipperDate" },
                values: new object[] { 1, "FC876771-8301-4765-B037-859AA899D708", new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), 0, new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ApplicationUserId", "CreateAt", "PayStatus", "ShipperDate" },
                values: new object[] { 2, "FC876771-8301-4765-B037-859AA899D708", new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), 0, new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ApplicationUserId", "CreateAt", "PayStatus", "ShipperDate" },
                values: new object[] { 3, "FC876771-8301-4765-B037-859AA899D708", new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), 0, new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "PayStatus", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 0, 1, 5000000.0 },
                    { 1, 2, 0, 2, 12000000.0 },
                    { 2, 3, 0, 1, 7000000.0 },
                    { 2, 4, 0, 3, 9000000.0 },
                    { 3, 5, 0, 1, 4000000.0 },
                    { 3, 6, 0, 2, 20000000.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC876771-8301-4765-B037-859AA899D708");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91",
                column: "ConcurrencyStamp",
                value: "76707d0f-2f6b-48e2-9576-c4529890efdb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { null, "7eaaac3d-b324-494a-a73a-d9f48e4313b8", "AQAAAAEAACcQAAAAEIpmMi6xtL4qrhTzHnfpXgvUWhndFCCbnfFpLxwcu8p8vo8/r1yibCZh24Da9BTC5g==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2020, 9, 14, 8, 48, 26, 968, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2020, 9, 14, 8, 48, 26, 969, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2020, 9, 14, 8, 48, 26, 969, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2020, 9, 14, 8, 48, 26, 969, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2020, 9, 14, 8, 48, 26, 969, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2020, 9, 14, 8, 48, 26, 969, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2020, 9, 14, 8, 48, 26, 969, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2020, 9, 14, 8, 48, 26, 969, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2020, 9, 14, 8, 48, 26, 969, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2020, 9, 14, 8, 48, 26, 969, DateTimeKind.Local).AddTicks(9241));
        }
    }
}
