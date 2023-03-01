using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorMyRide.Server.Migrations
{
    /// <inheritdoc />
    public partial class CustomTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customs",
                columns: new[] { "Id", "CreatedDate", "Description", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 1, 12, 28, 6, 694, DateTimeKind.Utc).AddTicks(2993), "Battery Repair and Replacement", 500.00m },
                    { 2, new DateTime(2023, 2, 1, 12, 28, 6, 694, DateTimeKind.Utc).AddTicks(2997), "Front side bulbs", 42.66m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customs");
        }
    }
}
