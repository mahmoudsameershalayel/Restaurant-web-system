using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "menuCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Breakfast" });

            migrationBuilder.InsertData(
                table: "menuCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Launch" });

            migrationBuilder.InsertData(
                table: "menuCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Dinner" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "menuCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "menuCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "menuCategories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
