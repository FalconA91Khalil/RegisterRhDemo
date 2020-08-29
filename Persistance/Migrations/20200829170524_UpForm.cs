using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class UpForm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Forms_FormId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Sections_FormId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "FormId",
                table: "Sections");

            migrationBuilder.AddColumn<int>(
                name: "FormId",
                table: "FormFields",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FormFields_FormId",
                table: "FormFields",
                column: "FormId");

            migrationBuilder.AddForeignKey(
                name: "FK_FormFields_Forms_FormId",
                table: "FormFields",
                column: "FormId",
                principalTable: "Forms",
                principalColumn: "FormId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormFields_Forms_FormId",
                table: "FormFields");

            migrationBuilder.DropIndex(
                name: "IX_FormFields_FormId",
                table: "FormFields");

            migrationBuilder.DropColumn(
                name: "FormId",
                table: "FormFields");

            migrationBuilder.AddColumn<int>(
                name: "FormId",
                table: "Sections",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sections_FormId",
                table: "Sections",
                column: "FormId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Forms_FormId",
                table: "Sections",
                column: "FormId",
                principalTable: "Forms",
                principalColumn: "FormId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
