using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class hhg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "770b5f8a-227d-4425-9b1e-7c5b0312ffb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3e24c43-cc64-4d27-a658-12eff5074c2f", "AQAAAAEAACcQAAAAEA0WbEYz25ECE45FlaTtm/D32OXzkOGwN0DiHhoyXcR5cdgYpm3EqlFC35tx0OhHRg==", "e8ffa330-2f61-4537-9a53-6c3f4ea8185a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1446937-109c-4e1a-97ce-0560442484f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c51f8bd-98f9-4eed-9ff1-b77f6f54f32f", "AQAAAAEAACcQAAAAEFVQQ4gVDcGYFfAyjWcOgvz8rxHVREpzDaipLP4VGNSxn2bWo06kll7BsXlt4Qd2zA==", "b261996b-a26c-4382-9d21-c5df8b9fa107" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "770b5f8a-227d-4425-9b1e-7c5b0312ffb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35bbf705-9f57-458d-bafe-13cda7cb797a", "AQAAAAEAACcQAAAAEPLaRGmA4dTqtLKKCPpCohzVMasAu+PlTMVFZsn8pFDI/PCbpKRLJ5k0JzpFEU8kNQ==", "b4e53118-c50a-4fa1-95eb-0e33cbb43778" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1446937-109c-4e1a-97ce-0560442484f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b131af2e-34d9-4a8f-9499-72317e51fa3f", "AQAAAAEAACcQAAAAEJw3yWzFwg+GQpcsSGXSEUSb+S4CX1awX0ZS5oflm9pA9S2HLRdpk4YhoL+HKJ/wKQ==", "b2676c5e-4923-4d02-b5d4-2251de622842" });
        }
    }
}
