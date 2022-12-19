using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class DeleteChefs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "FirstName", "ImageName", "JopTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "userType" },
                values: new object[] { "1", 0, "6175e790-bd8f-4c65-885e-833df1176286", "In charge of the whole kitchen", null, false, "Mahmoud", "chef-2.jpg", "Kitchen manager", "Sameer", false, null, null, null, null, null, false, "563ba6a3-0976-4214-bd3a-ee77d1e1aae4", false, null, "Chef" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "FirstName", "ImageName", "JopTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "userType" },
                values: new object[] { "2", 0, "286a19bb-da06-489f-9960-7f4bf7607484", "In charge of a section or station", null, false, "Khaled", "chef-3.jpg", "Section cook", "Majed", false, null, null, null, null, null, false, "c3959069-d1c5-49ed-9f51-19c14ff2556e", false, null, "Chef" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "FirstName", "ImageName", "JopTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "userType" },
                values: new object[] { "3", 0, "7dc8d68e-7a97-4589-a814-976ea1dfae63", "Preparation of a wide variety of foods", null, false, "Monzer", "chef-4.jpg", "Junior cook", "Ibrahim", false, null, null, null, null, null, false, "8f4f368f-8ba7-4f75-9e3e-18f9883c3f64", false, null, "Chef" });
        }
    }
}
