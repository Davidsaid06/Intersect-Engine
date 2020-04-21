using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations
{
    public partial class AddingWeaponSkills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxWeaponSkillsPoint",
                table: "Player_Items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "currentWeaponSkillPoint",
                table: "Player_Items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxDurability",
                table: "Player_Bank",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxWeaponSkillsPoint",
                table: "Player_Bank",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "currentDurability",
                table: "Player_Bank",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "currentWeaponSkillPoint",
                table: "Player_Bank",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxDurability",
                table: "Bag_Items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxWeaponSkillsPoint",
                table: "Bag_Items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "currentDurability",
                table: "Bag_Items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "currentWeaponSkillPoint",
                table: "Bag_Items",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxWeaponSkillsPoint",
                table: "Player_Items");

            migrationBuilder.DropColumn(
                name: "currentWeaponSkillPoint",
                table: "Player_Items");

            migrationBuilder.DropColumn(
                name: "MaxDurability",
                table: "Player_Bank");

            migrationBuilder.DropColumn(
                name: "MaxWeaponSkillsPoint",
                table: "Player_Bank");

            migrationBuilder.DropColumn(
                name: "currentDurability",
                table: "Player_Bank");

            migrationBuilder.DropColumn(
                name: "currentWeaponSkillPoint",
                table: "Player_Bank");

            migrationBuilder.DropColumn(
                name: "MaxDurability",
                table: "Bag_Items");

            migrationBuilder.DropColumn(
                name: "MaxWeaponSkillsPoint",
                table: "Bag_Items");

            migrationBuilder.DropColumn(
                name: "currentDurability",
                table: "Bag_Items");

            migrationBuilder.DropColumn(
                name: "currentWeaponSkillPoint",
                table: "Bag_Items");
        }
    }
}
