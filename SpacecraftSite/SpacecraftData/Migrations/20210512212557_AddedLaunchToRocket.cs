using Microsoft.EntityFrameworkCore.Migrations;

namespace SpacecraftData.Migrations
{
    public partial class AddedLaunchToRocket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Stages",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Stages");
        }
    }
}
