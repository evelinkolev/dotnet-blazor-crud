using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorMyRide.Server.Migrations
{
    /// <inheritdoc />
    public partial class CarTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Customs_CustomId",
                        column: x => x.CustomId,
                        principalTable: "Customs",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "CustomId", "LicensePlate", "Make", "Model", "VIN" },
                values: new object[,]
                {
                    { 1, "Cafe Latte", 1, "T93398", "Kia", "Optima Hybrid", "KNAGM4AD4G5093398" },
                    { 2, "Charcoal", 2, "T33096", "Hyundai", "Santa Fe Sport", "5XYZU3LB6EG133096" }
                });

            migrationBuilder.UpdateData(
                table: "Customs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 16, 8, 13, 15, 570, DateTimeKind.Utc).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Customs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 16, 8, 13, 15, 570, DateTimeKind.Utc).AddTicks(472));

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CustomId",
                table: "Cars",
                column: "CustomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.UpdateData(
                table: "Customs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 1, 12, 28, 6, 694, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Customs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 1, 12, 28, 6, 694, DateTimeKind.Utc).AddTicks(2997));
        }
    }
}
