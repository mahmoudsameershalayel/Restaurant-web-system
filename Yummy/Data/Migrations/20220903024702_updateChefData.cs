using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class updateChefData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Description", "ImageName", "JopTitle", "SecurityStamp" },
                values: new object[] { "7150abaf-2109-4b9e-b241-41dd98515b59", "In charge of the whole kitchen", "chef-2", "Kitchen manager", "e2cafae1-9ba5-4ba7-93f3-6ee983838be3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Description", "ImageName", "JopTitle", "SecurityStamp" },
                values: new object[] { "9c66a2a9-1bf6-4903-9f6d-7fd21c273ad2", "In charge of a section or station", "chef-3", "Section cook", "91432f24-4096-4c7d-8151-3342a6cccd62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Description", "ImageName", "JopTitle", "SecurityStamp" },
                values: new object[] { "2523d8de-8f72-4571-8d15-144538bab4bf", "Preparation of a wide variety of foods", "chef-4", "Junior cook", "2c6bc53f-9a2b-48fd-965a-1f2b6430e470" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Description", "ImageName", "JopTitle", "SecurityStamp" },
                values: new object[] { "8cdfca31-b561-41a0-b0ba-830878d981b0", null, "", null, "522d60e7-91ee-4e5f-964a-1ce9093fca13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Description", "ImageName", "JopTitle", "SecurityStamp" },
                values: new object[] { "469f6dae-35f8-4686-99a8-b292504252fd", null, "", null, "73365b47-343c-4bd7-bcb8-3a9156d9f507" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Description", "ImageName", "JopTitle", "SecurityStamp" },
                values: new object[] { "a0dda36a-3391-4fa2-a863-ecbfd5230871", null, "", null, "67095aa3-14f6-4612-8b0f-5054cbb6d0d5" });
        }
    }
}
