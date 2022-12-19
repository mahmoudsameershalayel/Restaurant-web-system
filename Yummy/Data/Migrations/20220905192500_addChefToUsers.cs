using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class addChefToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1446937-109c-4e1a-97ce-0560442484f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3dde3a5a-7105-48bb-9798-452452b506bc", "AQAAAAEAACcQAAAAEGJ85jKrFgqJQ2ptwYhupAiHCCsu2XIGoNeRxeNSZVS6qnPV7BCqJtFdoagEBllWmQ==", "d4d073c2-3502-4151-821b-2deab2975c0b" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "FirstName", "ImageName", "JopTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "userType" },
                values: new object[] { "770b5f8a-227d-4425-9b1e-7c5b0312ffb9", 0, "4ea9e654-07bc-4505-a6e2-907bc025867c", null, "chef@chef.com", false, "Chef", "", null, "Chef", false, null, "CHEF@CHEF.COM", null, "AQAAAAEAACcQAAAAEJMCoqKMbQXiYgigsm7Y5mrHJbsk3ZahfxlGyv7ZjwoaUUNVT5JWY4PMkQh2DDaHtA==", null, false, "a4fa0c71-caca-4279-b9c3-4158cf3eeef2", false, "Chef", "Chef" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6472ca7d-4acb-4550-9b9f-2d03321ad5e6", "770b5f8a-227d-4425-9b1e-7c5b0312ffb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6472ca7d-4acb-4550-9b9f-2d03321ad5e6", "770b5f8a-227d-4425-9b1e-7c5b0312ffb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "770b5f8a-227d-4425-9b1e-7c5b0312ffb9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1446937-109c-4e1a-97ce-0560442484f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "671b3e45-a9bf-4bbd-8e01-a1b89acbe3b5", "AQAAAAEAACcQAAAAELe9WfOOsM+hir+rEK314ymlvAlt6feoQFy94gMwOXIQ23PMlCgh18F6VOSW9aunbg==", "c4d07572-d193-43f4-acea-540e00d2629c" });
        }
    }
}
