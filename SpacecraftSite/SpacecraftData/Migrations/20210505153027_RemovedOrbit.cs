using Microsoft.EntityFrameworkCore.Migrations;

namespace SpacecraftData.Migrations
{
    public partial class RemovedOrbit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Orbit",
                table: "Spacecrafts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Orbit",
                table: "Spacecrafts",
                type: "TEXT",
                nullable: true);
        }
    }
}
