using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accounting.Migrations
{
    public partial class reset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Charts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TenantId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DisplayPosition = table.Column<int>(nullable: false),
                    PostingType = table.Column<int>(nullable: false),
                    ParentHeadingAccountId = table.Column<Guid>(nullable: true),
                    PostingAccount_ParentHeadingAccountId = table.Column<Guid>(nullable: true),
                    ChartId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Accounts_ParentHeadingAccountId",
                        column: x => x.ParentHeadingAccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accounts_Accounts_PostingAccount_ParentHeadingAccountId",
                        column: x => x.PostingAccount_ParentHeadingAccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accounts_Charts_ChartId",
                        column: x => x.ChartId,
                        principalTable: "Charts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ParentHeadingAccountId",
                table: "Accounts",
                column: "ParentHeadingAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_PostingAccount_ParentHeadingAccountId",
                table: "Accounts",
                column: "PostingAccount_ParentHeadingAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ChartId",
                table: "Accounts",
                column: "ChartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Charts");
        }
    }
}
