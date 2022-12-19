using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class addAboutTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aboutArticle",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstParagraph = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    List = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondParagraph = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aboutArticle", x => x.ArticleId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1446937-109c-4e1a-97ce-0560442484f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0a79be6-4fea-41ec-975f-d3858c6c5dd1", "AQAAAAEAACcQAAAAEBRvcAgdDTl31JhxNhyB1VuCOstMHamgccaY7qyDb96UopB1BSl7brPRQUupL8rw9w==", "e32ddb99-16ac-47cb-bee9-032f1bb45822" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aboutArticle");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1446937-109c-4e1a-97ce-0560442484f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3408fd40-26ef-44ad-881d-490963896b69", "AQAAAAEAACcQAAAAEEByR/mz2VxawyAux/hW+L3Q1Y+EsReCdrlP0kaFAPt1xfpAN9VNZNBZIpgEPKgq1Q==", "d5179aba-381a-4329-8b1f-6ca07bcc12a5" });
        }
    }
}
