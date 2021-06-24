using Microsoft.EntityFrameworkCore.Migrations;

namespace Accounting.Migrations
{
    public partial class SeeSetters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Accounts");

            migrationBuilder.AddColumn<int>(
                name: "HaveSet",
                table: "Accounts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrivateSet",
                table: "Accounts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HaveSet",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "PrivateSet",
                table: "Accounts");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
