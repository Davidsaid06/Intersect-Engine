using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations
{
    public partial class AddingLastUsedIpToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurDurability",
                table: "Player_Items");

            migrationBuilder.DropColumn(
                name: "CurWeaponSkillPoint",
                table: "Player_Items");

            migrationBuilder.DropColumn(
                name: "CurDurability",
                table: "Player_Bank");

            migrationBuilder.DropColumn(
                name: "CurWeaponSkillPoint",
                table: "Player_Bank");

            migrationBuilder.DropColumn(
                name: "CurDurability",
                table: "Bag_Items");

            migrationBuilder.DropColumn(
                name: "CurWeaponSkillPoint",
                table: "Bag_Items");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurDurability",
                table: "Player_Items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurWeaponSkillPoint",
                table: "Player_Items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurDurability",
                table: "Player_Bank",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurWeaponSkillPoint",
                table: "Player_Bank",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurDurability",
                table: "Bag_Items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurWeaponSkillPoint",
                table: "Bag_Items",
                nullable: false,
                defaultValue: 0);
        }
    }
}
