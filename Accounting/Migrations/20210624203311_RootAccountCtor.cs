using Microsoft.EntityFrameworkCore.Migrations;

namespace Accounting.Migrations
{
    public partial class RootAccountCtor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountGroup",
                table: "Accounts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Accounts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DisplayPosition",
                table: "Accounts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Accounts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Accounts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountGroup",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "DisplayPosition",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Accounts");
        }
    }
}
