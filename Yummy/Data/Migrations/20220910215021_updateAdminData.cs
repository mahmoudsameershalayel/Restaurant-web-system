using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class updateAdminData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1446937-109c-4e1a-97ce-0560442484f5",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "ImageName", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c04d3f5d-df23-4a1d-9ff3-6d82a5aa5599", "mahmoud@admin.com", "Mahmoud", "ma.jpg", "Sameer", "MAHMOUD@ADMIN.COM", "AQAAAAEAACcQAAAAEE5FxpsZYdwP1G6wMCIYcGrGsqy/1XJCFXXjJJ4yoxFzsmHQwHozqF8POURzfRelyQ==", "efedce9d-454a-4739-9e32-dc9f38521e3b", "Mahmoud_Sameer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1446937-109c-4e1a-97ce-0560442484f5",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "ImageName", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "beceb595-b236-4459-a31e-a6baaf378613", "admin@admin.com", "Admin", "", "Admin", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEChvYn689RtoNSZFNBpRYGZWdCnV2qlmIVqaIWS44rolN6ycgwZhrEBwe9v79SAScQ==", "113f2146-8b78-443c-b410-f8b122f9b7a7", "Admin" });
        }
    }
}
