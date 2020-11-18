using Microsoft.EntityFrameworkCore.Migrations;

namespace SaabeEnergy_backend.Migrations
{
    public partial class mig_editCertificates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Certificates",
                maxLength: 500,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Certificates");
        }
    }
}
