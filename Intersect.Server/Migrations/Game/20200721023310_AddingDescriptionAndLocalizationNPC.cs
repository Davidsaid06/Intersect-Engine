using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations.Game
{
    public partial class AddingDescriptionAndLocalizationNPC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Npcs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Localization",
                table: "Npcs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Npcs");

            migrationBuilder.DropColumn(
                name: "Localization",
                table: "Npcs");
        }
    }
}
