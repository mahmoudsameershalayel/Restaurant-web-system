using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class addChef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChefId",
                table: "meals",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_meals_ChefId",
                table: "meals",
                column: "ChefId");

            migrationBuilder.AddForeignKey(
                name: "FK_meals_AspNetUsers_ChefId",
                table: "meals",
                column: "ChefId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_meals_AspNetUsers_ChefId",
                table: "meals");

            migrationBuilder.DropIndex(
                name: "IX_meals_ChefId",
                table: "meals");

            migrationBuilder.DropColumn(
                name: "ChefId",
                table: "meals");
        }
    }
}
