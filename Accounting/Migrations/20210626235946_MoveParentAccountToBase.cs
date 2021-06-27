using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accounting.Migrations
{
    public partial class MoveParentAccountToBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Accounts_ParentHeadingAccountId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Accounts_PostingAccount_ParentHeadingAccountId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_ParentHeadingAccountId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_PostingAccount_ParentHeadingAccountId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "ParentHeadingAccountId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "PostingAccount_ParentHeadingAccountId",
                table: "Accounts");

            migrationBuilder.AddColumn<Guid>(
                name: "ParentAccountId",
                table: "Accounts",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "HeadingAccountId",
                table: "Accounts",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PostingAccount_HeadingAccountId",
                table: "Accounts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ParentAccountId",
                table: "Accounts",
                column: "ParentAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_HeadingAccountId",
                table: "Accounts",
                column: "HeadingAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_PostingAccount_HeadingAccountId",
                table: "Accounts",
                column: "PostingAccount_HeadingAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Accounts_ParentAccountId",
                table: "Accounts",
                column: "ParentAccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Accounts_HeadingAccountId",
                table: "Accounts",
                column: "HeadingAccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Accounts_PostingAccount_HeadingAccountId",
                table: "Accounts",
                column: "PostingAccount_HeadingAccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Accounts_ParentAccountId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Accounts_HeadingAccountId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Accounts_PostingAccount_HeadingAccountId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_ParentAccountId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_HeadingAccountId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_PostingAccount_HeadingAccountId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "ParentAccountId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "HeadingAccountId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "PostingAccount_HeadingAccountId",
                table: "Accounts");

            migrationBuilder.AddColumn<Guid>(
                name: "ParentHeadingAccountId",
                table: "Accounts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PostingAccount_ParentHeadingAccountId",
                table: "Accounts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ParentHeadingAccountId",
                table: "Accounts",
                column: "ParentHeadingAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_PostingAccount_ParentHeadingAccountId",
                table: "Accounts",
                column: "PostingAccount_ParentHeadingAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Accounts_ParentHeadingAccountId",
                table: "Accounts",
                column: "ParentHeadingAccountId",
                principalTable: "Accounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Accounts_PostingAccount_ParentHeadingAccountId",
                table: "Accounts",
                column: "PostingAccount_ParentHeadingAccountId",
                principalTable: "Accounts",
                principalColumn: "Id");
        }
    }
}
