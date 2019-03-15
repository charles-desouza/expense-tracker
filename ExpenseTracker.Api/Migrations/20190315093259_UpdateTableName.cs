using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseTracker.Api.Migrations
{
    public partial class UpdateTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Income_incomeSources_SourceId",
                table: "Income");

            migrationBuilder.DropPrimaryKey(
                name: "PK_incomeSources",
                table: "incomeSources");

            migrationBuilder.RenameTable(
                name: "incomeSources",
                newName: "IncomeSources");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IncomeSources",
                table: "IncomeSources",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Income_IncomeSources_SourceId",
                table: "Income",
                column: "SourceId",
                principalTable: "IncomeSources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Income_IncomeSources_SourceId",
                table: "Income");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IncomeSources",
                table: "IncomeSources");

            migrationBuilder.RenameTable(
                name: "IncomeSources",
                newName: "incomeSources");

            migrationBuilder.AddPrimaryKey(
                name: "PK_incomeSources",
                table: "incomeSources",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Income_incomeSources_SourceId",
                table: "Income",
                column: "SourceId",
                principalTable: "incomeSources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
