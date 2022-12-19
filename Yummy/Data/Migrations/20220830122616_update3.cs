using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_meals_AspNetUsers_ApplicationUserId",
                table: "meals");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "meals",
                newName: "ChefId");

            migrationBuilder.RenameIndex(
                name: "IX_meals_ApplicationUserId",
                table: "meals",
                newName: "IX_meals_ChefId");

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

            migrationBuilder.RenameColumn(
                name: "ChefId",
                table: "meals",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_meals_ChefId",
                table: "meals",
                newName: "IX_meals_ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_meals_AspNetUsers_ApplicationUserId",
                table: "meals",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
