using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaabeEnergy_backend.Migrations
{
    public partial class mig_addTableArticles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArticleGroupId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    PageTitle = table.Column<string>(maxLength: 80, nullable: false),
                    PageDescription = table.Column<string>(maxLength: 500, nullable: true),
                    PageDCSubject = table.Column<string>(maxLength: 200, nullable: true),
                    Picture = table.Column<string>(maxLength: 500, nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ShowOrder = table.Column<int>(nullable: false),
                    IsNewest = table.Column<bool>(nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    Culture = table.Column<string>(maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_ArticleGroups_ArticleGroupId",
                        column: x => x.ArticleGroupId,
                        principalTable: "ArticleGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleGroupId",
                table: "Articles",
                column: "ArticleGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");
        }
    }
}
