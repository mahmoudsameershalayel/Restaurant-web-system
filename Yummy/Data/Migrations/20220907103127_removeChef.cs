using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class removeChef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "beceb595-b236-4459-a31e-a6baaf378613", "AQAAAAEAACcQAAAAEChvYn689RtoNSZFNBpRYGZWdCnV2qlmIVqaIWS44rolN6ycgwZhrEBwe9v79SAScQ==", "113f2146-8b78-443c-b410-f8b122f9b7a7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1446937-109c-4e1a-97ce-0560442484f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c51f8bd-98f9-4eed-9ff1-b77f6f54f32f", "AQAAAAEAACcQAAAAEFVQQ4gVDcGYFfAyjWcOgvz8rxHVREpzDaipLP4VGNSxn2bWo06kll7BsXlt4Qd2zA==", "b261996b-a26c-4382-9d21-c5df8b9fa107" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "FirstName", "ImageName", "JopTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "userType" },
                values: new object[] { "770b5f8a-227d-4425-9b1e-7c5b0312ffb9", 0, "e3e24c43-cc64-4d27-a658-12eff5074c2f", null, "chef@chef.com", false, "Chef", "", null, "Chef", false, null, "CHEF@CHEF.COM", null, "AQAAAAEAACcQAAAAEA0WbEYz25ECE45FlaTtm/D32OXzkOGwN0DiHhoyXcR5cdgYpm3EqlFC35tx0OhHRg==", null, false, "e8ffa330-2f61-4537-9a53-6c3f4ea8185a", false, "Chef", "Chef" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6472ca7d-4acb-4550-9b9f-2d03321ad5e6", "770b5f8a-227d-4425-9b1e-7c5b0312ffb9" });
        }
    }
}
