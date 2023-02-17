using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorMyRide.Server.Migrations
{
    /// <inheritdoc />
    public partial class DriverTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drivers_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Customs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 17, 8, 11, 26, 492, DateTimeKind.Utc).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Customs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 17, 8, 11, 26, 492, DateTimeKind.Utc).AddTicks(5229));

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "Address", "CarId", "Email", "FullName", "Gender", "NationalCardNumber", "PIN", "Phone" },
                values: new object[,]
                {
                    { 1, "Strelbishte District", 1, "testova.teodora@gmail.com", "Teodora Testova", "female", "Pending Edit", "Pending Edit", "123-456-789" },
                    { 2, "Edit or Delete", 2, "Edit or Delete", "Edit or Delete", "Edit or Delete", "Edit or Delete", "Edit or Delete", "Edit or Delete" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_CarId",
                table: "Drivers",
                column: "CarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");

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
        }
    }
}
