using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoyalitySystem.Migrations
{
    public partial class AddedMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2024, 3, 26, 18, 52, 19, 781, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.InsertData(
                table: "LoyalityUsers",
                columns: new[] { "Id", "CompanyId", "Discount", "UserId" },
                values: new object[,]
                {
                    { 2, 1, 15, 55 },
                    { 3, 1, 40, 11 },
                    { 4, 1, 5, 15 }
                });

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 22 },
                    { 2, 22 },
                    { 3, 22 },
                    { 4, 22 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LoyalityUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LoyalityUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LoyalityUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2024, 3, 25, 14, 18, 9, 635, DateTimeKind.Local).AddTicks(1281));
        }
    }
}
