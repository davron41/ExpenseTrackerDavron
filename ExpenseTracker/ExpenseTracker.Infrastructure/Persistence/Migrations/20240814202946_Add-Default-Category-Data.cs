using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExpenseTracker.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultCategoryData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 14, 20, 29, 45, 678, DateTimeKind.Utc).AddTicks(441), "Monthly grocery expenses", "Grocery", null },
                    { 2, new DateTime(2024, 8, 14, 20, 29, 45, 678, DateTimeKind.Utc).AddTicks(444), "Monthly grocery expenses", "Community services", null },
                    { 3, new DateTime(2024, 8, 14, 20, 29, 45, 678, DateTimeKind.Utc).AddTicks(445), "Regular job income", "Salary", null },
                    { 4, new DateTime(2024, 8, 14, 20, 29, 45, 678, DateTimeKind.Utc).AddTicks(446), "Side hustle", "Other incomes", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
