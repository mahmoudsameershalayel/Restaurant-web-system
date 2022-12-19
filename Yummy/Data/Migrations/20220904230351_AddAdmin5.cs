using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class AddAdmin5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6472ca7d-4acb-4550-9b9f-2d03321ad5e6", "6472ca7d-4acb-4550-9b9f-2d03321ad5e6", "Chef", "CHEF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9a00de05-ab2c-4692-82b2-d33f0f50eb7e", "9a00de05-ab2c-4692-82b2-d33f0f50eb7e", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "FirstName", "ImageName", "JopTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "userType" },
                values: new object[] { "f1446937-109c-4e1a-97ce-0560442484f5", 0, "671b3e45-a9bf-4bbd-8e01-a1b89acbe3b5", null, "admin@admin.com", false, "Admin", "", null, "Admin", false, null, "ADMIN@ADMIN.COM", null, "AQAAAAEAACcQAAAAELe9WfOOsM+hir+rEK314ymlvAlt6feoQFy94gMwOXIQ23PMlCgh18F6VOSW9aunbg==", null, false, "c4d07572-d193-43f4-acea-540e00d2629c", false, "Admin", "Administrator" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9a00de05-ab2c-4692-82b2-d33f0f50eb7e", "f1446937-109c-4e1a-97ce-0560442484f5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6472ca7d-4acb-4550-9b9f-2d03321ad5e6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a00de05-ab2c-4692-82b2-d33f0f50eb7e", "f1446937-109c-4e1a-97ce-0560442484f5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a00de05-ab2c-4692-82b2-d33f0f50eb7e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1446937-109c-4e1a-97ce-0560442484f5");
        }
    }
}
