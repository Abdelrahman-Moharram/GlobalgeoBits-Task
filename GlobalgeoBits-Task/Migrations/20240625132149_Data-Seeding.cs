using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GlobalgeoBits_Task.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Color", "Model", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Rayban", "red", "xyz", "Rayban xyz red", 0m },
                    { 2, "Police", "white", "abc", "Police abc white", 0m },
                    { 3, "Fred", "Black", "vvv", "Fred vvv red", 0m },
                    { 4, "Rayban", "purble", "abc", "Rayban abc purble", 0m },
                    { 5, "Police", "red", "xyz", "Police xyz green", 0m },
                    { 6, "Rayban", "red", "xyz", "Fred ccc red", 0m }
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
        }
    }
}
