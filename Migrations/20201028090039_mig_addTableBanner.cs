using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaabeEnergy_backend.Migrations
{
    public partial class mig_addTableBanner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banner",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Picture = table.Column<string>(maxLength: 500, nullable: true),
                    Position = table.Column<byte>(nullable: false),
                    PageType = table.Column<byte>(nullable: false),
                    FileType = table.Column<byte>(nullable: false),
                    PageTitle = table.Column<string>(maxLength: 80, nullable: false),
                    PageDescription = table.Column<string>(maxLength: 500, nullable: true),
                    PageDCSubject = table.Column<string>(maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    DateX = table.Column<DateTime>(nullable: false),
                    ShowOrder = table.Column<int>(nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    Culture = table.Column<string>(maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banner", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banner");
        }
    }
}
