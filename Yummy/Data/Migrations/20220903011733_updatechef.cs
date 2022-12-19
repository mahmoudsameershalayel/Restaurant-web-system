using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class updatechef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "FirstName", "ImageName", "JopTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "userType" },
                values: new object[] { "1", 0, "8cdfca31-b561-41a0-b0ba-830878d981b0", null, null, false, "Mahmoud", "", null, "Sameer", false, null, null, null, null, null, false, "522d60e7-91ee-4e5f-964a-1ce9093fca13", false, null, "Chef" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "FirstName", "ImageName", "JopTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "userType" },
                values: new object[] { "2", 0, "469f6dae-35f8-4686-99a8-b292504252fd", null, null, false, "Khaled", "", null, "Majed", false, null, null, null, null, null, false, "73365b47-343c-4bd7-bcb8-3a9156d9f507", false, null, "Chef" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "FirstName", "ImageName", "JopTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "userType" },
                values: new object[] { "3", 0, "a0dda36a-3391-4fa2-a863-ecbfd5230871", null, null, false, "Monzer", "", null, "Ibrahim", false, null, null, null, null, null, false, "67095aa3-14f6-4612-8b0f-5054cbb6d0d5", false, null, "Chef" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
