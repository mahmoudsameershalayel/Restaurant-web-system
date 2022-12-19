using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class addAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1446937-109c-4e1a-97ce-0560442484f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6a7d8bb-1937-4faf-8bc4-e707869b8042", "AQAAAAEAACcQAAAAEPq673vE/Z9WquKk1/2Xmn4U7Bd4SH5s3caidr63uZFep9hPAG7EOSNFWDABflZR1Q==", "8f58a9db-826d-4990-9b59-05a9db407299" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1446937-109c-4e1a-97ce-0560442484f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9e8d865-45fc-4d21-a2c6-a6bc87b6c05a", "AQAAAAEAACcQAAAAECWV5J0pbQeaXvMBqvGXiD3FIyx6hG2YAHyxklMVsv9ROeENg/+nB6/v9ucyVj9i9Q==", "23e90976-58ff-4323-ac87-0b9cb06bdc82" });
        }
    }
}
