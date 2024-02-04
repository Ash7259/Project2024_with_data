using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project2.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CarName", "CreatedBy", "CustomerId", "DateCreated", "DateUpdated", "IsCompleted", "PurchaseId", "RentEnd", "RentStart", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Toyota", "System", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, new DateTime(2024, 2, 3, 18, 20, 1, 203, DateTimeKind.Local).AddTicks(8433), new DateTime(2024, 1, 27, 18, 20, 1, 203, DateTimeKind.Local).AddTicks(8420), "System" },
                    { 2, "Nissan", "System", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, new DateTime(2024, 2, 4, 18, 20, 1, 203, DateTimeKind.Local).AddTicks(8443), new DateTime(2024, 1, 27, 18, 20, 1, 203, DateTimeKind.Local).AddTicks(8442), "System" },
                    { 3, "Honda", "System", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, new DateTime(2024, 2, 5, 18, 20, 1, 203, DateTimeKind.Local).AddTicks(8446), new DateTime(2024, 1, 27, 18, 20, 1, 203, DateTimeKind.Local).AddTicks(8446), "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
