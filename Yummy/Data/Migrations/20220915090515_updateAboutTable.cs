using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class updateAboutTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstParagraph",
                table: "aboutArticle");

            migrationBuilder.RenameColumn(
                name: "SecondParagraph",
                table: "aboutArticle",
                newName: "ArticleBody");

            migrationBuilder.AlterColumn<string>(
                name: "List",
                table: "aboutArticle",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1446937-109c-4e1a-97ce-0560442484f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea8b861b-25ec-49bc-a815-8f73def81152", "AQAAAAEAACcQAAAAEB5spvT7HkMveut2ey4dGsvMkvEHvRMnnp6OBntjJG6ZpoofXYz2ePpjFWFA9+DTmQ==", "612962be-bccd-4744-8616-f347620554cf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ArticleBody",
                table: "aboutArticle",
                newName: "SecondParagraph");

            migrationBuilder.AlterColumn<string>(
                name: "List",
                table: "aboutArticle",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstParagraph",
                table: "aboutArticle",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1446937-109c-4e1a-97ce-0560442484f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0a79be6-4fea-41ec-975f-d3858c6c5dd1", "AQAAAAEAACcQAAAAEBRvcAgdDTl31JhxNhyB1VuCOstMHamgccaY7qyDb96UopB1BSl7brPRQUupL8rw9w==", "e32ddb99-16ac-47cb-bee9-032f1bb45822" });
        }
    }
}
