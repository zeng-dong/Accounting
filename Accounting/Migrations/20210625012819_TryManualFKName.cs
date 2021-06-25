using Microsoft.EntityFrameworkCore.Migrations;

namespace Accounting.Migrations
{
    public partial class TryManualFKName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Accounts_ParentHeadingAccountId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Accounts_PostingAccount_ParentHeadingAccountId",
                table: "Accounts");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Accounts_ParentHeadingAccountId",
                table: "Accounts",
                column: "ParentHeadingAccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Accounts_PostingAccount_ParentHeadingAccountId",
                table: "Accounts",
                column: "PostingAccount_ParentHeadingAccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Accounts_ParentHeadingAccountId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Accounts_PostingAccount_ParentHeadingAccountId",
                table: "Accounts");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Accounts_ParentHeadingAccountId",
                table: "Accounts",
                column: "ParentHeadingAccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Accounts_PostingAccount_ParentHeadingAccountId",
                table: "Accounts",
                column: "PostingAccount_ParentHeadingAccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
