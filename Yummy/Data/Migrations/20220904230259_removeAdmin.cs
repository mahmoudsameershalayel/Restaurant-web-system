using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class removeAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "f1446937-109c-4e1a-97ce-0560442484f5", 0, "e6a7d8bb-1937-4faf-8bc4-e707869b8042", null, "admin@admin.com", false, "Admin", "", null, "Admin", false, null, "ADMIN@ADMIN.COM", null, "AQAAAAEAACcQAAAAEPq673vE/Z9WquKk1/2Xmn4U7Bd4SH5s3caidr63uZFep9hPAG7EOSNFWDABflZR1Q==", null, false, "8f58a9db-826d-4990-9b59-05a9db407299", false, "Admin", "Administrator" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9a00de05-ab2c-4692-82b2-d33f0f50eb7e", "f1446937-109c-4e1a-97ce-0560442484f5" });
        }
    }
}
