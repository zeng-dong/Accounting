using Microsoft.EntityFrameworkCore.Migrations;

namespace Accounting.Migrations
{
    public partial class RenameAccountGroupToGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountGroup",
                table: "Accounts");

            migrationBuilder.AddColumn<int>(
                name: "Group",
                table: "Accounts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Group",
                table: "Accounts");

            migrationBuilder.AddColumn<int>(
                name: "AccountGroup",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
