using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class gg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "770b5f8a-227d-4425-9b1e-7c5b0312ffb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ea9e654-07bc-4505-a6e2-907bc025867c", "AQAAAAEAACcQAAAAEJMCoqKMbQXiYgigsm7Y5mrHJbsk3ZahfxlGyv7ZjwoaUUNVT5JWY4PMkQh2DDaHtA==", "a4fa0c71-caca-4279-b9c3-4158cf3eeef2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1446937-109c-4e1a-97ce-0560442484f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3dde3a5a-7105-48bb-9798-452452b506bc", "AQAAAAEAACcQAAAAEGJ85jKrFgqJQ2ptwYhupAiHCCsu2XIGoNeRxeNSZVS6qnPV7BCqJtFdoagEBllWmQ==", "d4d073c2-3502-4151-821b-2deab2975c0b" });
        }
    }
}
