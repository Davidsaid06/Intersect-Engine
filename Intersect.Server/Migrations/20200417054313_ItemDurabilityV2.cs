using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations
{
    public partial class ItemDurabilityV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Durability",
                table: "Player_Items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeaponSkill",
                table: "Player_Items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Durability",
                table: "Player_Bank",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeaponSkill",
                table: "Player_Bank",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Durability",
                table: "Bag_Items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeaponSkill",
                table: "Bag_Items",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Durability",
                table: "Player_Items");

            migrationBuilder.DropColumn(
                name: "WeaponSkill",
                table: "Player_Items");

            migrationBuilder.DropColumn(
                name: "Durability",
                table: "Player_Bank");

            migrationBuilder.DropColumn(
                name: "WeaponSkill",
                table: "Player_Bank");

            migrationBuilder.DropColumn(
                name: "Durability",
                table: "Bag_Items");

            migrationBuilder.DropColumn(
                name: "WeaponSkill",
                table: "Bag_Items");
        }
    }
}
