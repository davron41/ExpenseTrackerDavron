using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExpenseTracker.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_Transfer_Date : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Transfer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Transfer");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 17, 10, 43, 2, 139, DateTimeKind.Utc).AddTicks(804), "Monthly grocery expenses", "Grocery", 0, null },
                    { 2, new DateTime(2024, 8, 17, 10, 43, 2, 139, DateTimeKind.Utc).AddTicks(811), "Monthly grocery expenses", "Community services", 0, null },
                    { 3, new DateTime(2024, 8, 17, 10, 43, 2, 139, DateTimeKind.Utc).AddTicks(813), "Regular job income", "Salary", 0, null },
                    { 4, new DateTime(2024, 8, 17, 10, 43, 2, 139, DateTimeKind.Utc).AddTicks(814), "Side hustle", "Other incomes", 0, null }
                });
        }
    }
}
