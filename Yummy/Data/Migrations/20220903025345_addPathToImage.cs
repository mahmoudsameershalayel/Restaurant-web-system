using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class addPathToImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "ImageName", "SecurityStamp" },
                values: new object[] { "6175e790-bd8f-4c65-885e-833df1176286", "chef-2.jpg", "563ba6a3-0976-4214-bd3a-ee77d1e1aae4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "ImageName", "SecurityStamp" },
                values: new object[] { "286a19bb-da06-489f-9960-7f4bf7607484", "chef-3.jpg", "c3959069-d1c5-49ed-9f51-19c14ff2556e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "ImageName", "SecurityStamp" },
                values: new object[] { "7dc8d68e-7a97-4589-a814-976ea1dfae63", "chef-4.jpg", "8f4f368f-8ba7-4f75-9e3e-18f9883c3f64" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "ImageName", "SecurityStamp" },
                values: new object[] { "7150abaf-2109-4b9e-b241-41dd98515b59", "chef-2", "e2cafae1-9ba5-4ba7-93f3-6ee983838be3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "ImageName", "SecurityStamp" },
                values: new object[] { "9c66a2a9-1bf6-4903-9f6d-7fd21c273ad2", "chef-3", "91432f24-4096-4c7d-8151-3342a6cccd62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "ImageName", "SecurityStamp" },
                values: new object[] { "2523d8de-8f72-4571-8d15-144538bab4bf", "chef-4", "2c6bc53f-9a2b-48fd-965a-1f2b6430e470" });
        }
    }
}
