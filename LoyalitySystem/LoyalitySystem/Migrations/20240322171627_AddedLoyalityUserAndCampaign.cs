using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoyalitySystem.Migrations
{
    public partial class AddedLoyalityUserAndCampaign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campaign",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaign", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoyalityUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoyalityUser", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Campaign",
                columns: new[] { "Id", "CompanyName", "Duration", "StartDate" },
                values: new object[] { 1, "Telecomunication", 30, new DateTime(2024, 3, 22, 18, 16, 24, 862, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.InsertData(
                table: "LoyalityUser",
                columns: new[] { "Id", "CompanyId", "Discount", "UserId" },
                values: new object[] { 1, 1, 25, 22 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Campaign");

            migrationBuilder.DropTable(
                name: "LoyalityUser");
        }
    }
}
