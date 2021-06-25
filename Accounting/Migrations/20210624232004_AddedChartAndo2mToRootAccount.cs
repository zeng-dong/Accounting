using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accounting.Migrations
{
    public partial class AddedChartAndo2mToRootAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Accounts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "ChartId",
                table: "Accounts",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ChartId",
                table: "Accounts",
                column: "ChartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Charts_ChartId",
                table: "Accounts",
                column: "ChartId",
                principalTable: "Charts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Charts_ChartId",
                table: "Accounts");

            migrationBuilder.DropTable(
                name: "Charts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_ChartId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "ChartId",
                table: "Accounts");
        }
    }
}
