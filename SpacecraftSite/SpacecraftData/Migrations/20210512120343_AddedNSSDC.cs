using Microsoft.EntityFrameworkCore.Migrations;

namespace SpacecraftData.Migrations
{
    public partial class AddedNSSDC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NSSDC",
                table: "Spacecrafts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NSSDC",
                table: "Spacecrafts");
        }
    }
}
