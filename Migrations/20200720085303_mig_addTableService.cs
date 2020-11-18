using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaabeEnergy_backend.Migrations
{
    public partial class mig_addTableService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceUs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Picture = table.Column<string>(maxLength: 500, nullable: true),
                    Logo = table.Column<string>(maxLength: 500, nullable: true),
                    ClassName = table.Column<string>(maxLength: 500, nullable: true),
                    Description = table.Column<string>(maxLength: 2000, nullable: true),
                    IsNewest = table.Column<bool>(nullable: false),
                    ShowOrder = table.Column<int>(nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    Culture = table.Column<string>(maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceUs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceUs");
        }
    }
}
