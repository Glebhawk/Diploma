using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpacecraftData.Migrations
{
    public partial class CheckLaunchToSateliteBinding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LaunchId",
                table: "Spacecrafts",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Rockets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Mass = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    CountryId = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rockets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rockets_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Launches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LaunchDate = table.Column<DateTime>(nullable: false),
                    Success = table.Column<bool>(nullable: false),
                    LaunchSite = table.Column<string>(nullable: true),
                    RocketId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Launches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Launches_Rockets_RocketId",
                        column: x => x.RocketId,
                        principalTable: "Rockets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Engines = table.Column<string>(nullable: true),
                    Fuel = table.Column<string>(nullable: true),
                    RocketId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stages_Rockets_RocketId",
                        column: x => x.RocketId,
                        principalTable: "Rockets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Spacecrafts_LaunchId",
                table: "Spacecrafts",
                column: "LaunchId");

            migrationBuilder.CreateIndex(
                name: "IX_Launches_RocketId",
                table: "Launches",
                column: "RocketId");

            migrationBuilder.CreateIndex(
                name: "IX_Rockets_CountryId",
                table: "Rockets",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Stages_RocketId",
                table: "Stages",
                column: "RocketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Spacecrafts_Launches_LaunchId",
                table: "Spacecrafts",
                column: "LaunchId",
                principalTable: "Launches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spacecrafts_Launches_LaunchId",
                table: "Spacecrafts");

            migrationBuilder.DropTable(
                name: "Launches");

            migrationBuilder.DropTable(
                name: "Stages");

            migrationBuilder.DropTable(
                name: "Rockets");

            migrationBuilder.DropIndex(
                name: "IX_Spacecrafts_LaunchId",
                table: "Spacecrafts");

            migrationBuilder.DropColumn(
                name: "LaunchId",
                table: "Spacecrafts");
        }
    }
}
