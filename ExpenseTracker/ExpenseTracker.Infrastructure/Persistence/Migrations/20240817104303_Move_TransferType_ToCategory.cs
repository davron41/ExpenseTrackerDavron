using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Move_TransferType_ToCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Transfer");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Transfer");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Transfer");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Transfer",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Type" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 43, 2, 139, DateTimeKind.Utc).AddTicks(804), 0 });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Type" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 43, 2, 139, DateTimeKind.Utc).AddTicks(811), 0 });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Type" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 43, 2, 139, DateTimeKind.Utc).AddTicks(813), 0 });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Type" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 43, 2, 139, DateTimeKind.Utc).AddTicks(814), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "Transfer");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Category");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Transfer",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Transfer",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Transfer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 20, 29, 45, 678, DateTimeKind.Utc).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 20, 29, 45, 678, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 20, 29, 45, 678, DateTimeKind.Utc).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 20, 29, 45, 678, DateTimeKind.Utc).AddTicks(446));
        }
    }
}
