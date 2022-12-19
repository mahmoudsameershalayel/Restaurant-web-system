using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class eventdatetb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EventDate",
                table: "events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1446937-109c-4e1a-97ce-0560442484f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9634b72-9fca-41a5-b332-9abb41b7a0c3", "AQAAAAEAACcQAAAAEFD7UULzLrkpepK8s5sXm5PHH+a/bOneRQJLJoD9zo0jqVcwM2Y91zWQhqSPnfwqGg==", "c87acc7f-2c84-4e9a-aff6-82ea3386a525" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventDate",
                table: "events");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1446937-109c-4e1a-97ce-0560442484f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c04d3f5d-df23-4a1d-9ff3-6d82a5aa5599", "AQAAAAEAACcQAAAAEE5FxpsZYdwP1G6wMCIYcGrGsqy/1XJCFXXjJJ4yoxFzsmHQwHozqF8POURzfRelyQ==", "efedce9d-454a-4739-9e32-dc9f38521e3b" });
        }
    }
}
