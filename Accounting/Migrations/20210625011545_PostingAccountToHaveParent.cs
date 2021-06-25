using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accounting.Migrations
{
    public partial class PostingAccountToHaveParent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PostingAccount_ParentHeadingAccountId",
                table: "Accounts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_PostingAccount_ParentHeadingAccountId",
                table: "Accounts",
                column: "PostingAccount_ParentHeadingAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Accounts_PostingAccount_ParentHeadingAccountId",
                table: "Accounts",
                column: "PostingAccount_ParentHeadingAccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Accounts_PostingAccount_ParentHeadingAccountId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_PostingAccount_ParentHeadingAccountId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "PostingAccount_ParentHeadingAccountId",
                table: "Accounts");
        }
    }
}
