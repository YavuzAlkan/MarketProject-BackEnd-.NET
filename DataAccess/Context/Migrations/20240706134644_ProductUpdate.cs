using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Context.Migrations
{
    /// <inheritdoc />
    public partial class ProductUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "Name", "Price", "Quantity", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8416), null, "Elma", 23.5, 25, 1, null },
                    { 2, 1, new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8420), null, "Salatalık", 27.899999999999999, 45, 1, null },
                    { 3, 2, new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8422), null, "Telefon", 27.5, 3, 1, null },
                    { 4, 2, new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8423), null, "Tablet", 18.699999999999999, 6, 1, null },
                    { 5, 3, new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8424), null, "Sucuk", 400.0, 45, 1, null },
                    { 6, 3, new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8425), null, "Peynir", 280.0, 34, 1, null },
                    { 7, 5, new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8455), null, "Filtre Kahve", 85.0, 21, 1, null },
                    { 8, 5, new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8457), null, "Türk Kahvesi", 50.0, 15, 1, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 4, 15, 53, 53, 426, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 4, 15, 53, 53, 426, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 4, 15, 53, 53, 426, DateTimeKind.Local).AddTicks(5587));
        }
    }
}
