using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaabeEnergy_backend.Migrations
{
    public partial class mig_addTableArticleGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticleGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParentId = table.Column<int>(nullable: true),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    PageTitle = table.Column<string>(maxLength: 80, nullable: false),
                    PageDescription = table.Column<string>(maxLength: 500, nullable: true),
                    PageDCSubject = table.Column<string>(maxLength: 200, nullable: true),
                    Picture = table.Column<string>(maxLength: 500, nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ShowOrder = table.Column<int>(nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    Culture = table.Column<string>(maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticleGroups_ArticleGroups_ParentId",
                        column: x => x.ParentId,
                        principalTable: "ArticleGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleGroups_ParentId",
                table: "ArticleGroups",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleGroups");
        }
    }
}
