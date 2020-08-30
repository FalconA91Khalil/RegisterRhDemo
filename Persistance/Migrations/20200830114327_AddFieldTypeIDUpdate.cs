using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class AddFieldTypeIDUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormFields_FieldType_FieldTypeId",
                table: "FormFields");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FieldType",
                table: "FieldType");

            migrationBuilder.RenameTable(
                name: "FieldType",
                newName: "FieldTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FieldTypes",
                table: "FieldTypes",
                column: "FieldTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_FormFields_FieldTypes_FieldTypeId",
                table: "FormFields",
                column: "FieldTypeId",
                principalTable: "FieldTypes",
                principalColumn: "FieldTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormFields_FieldTypes_FieldTypeId",
                table: "FormFields");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FieldTypes",
                table: "FieldTypes");

            migrationBuilder.RenameTable(
                name: "FieldTypes",
                newName: "FieldType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FieldType",
                table: "FieldType",
                column: "FieldTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_FormFields_FieldType_FieldTypeId",
                table: "FormFields",
                column: "FieldTypeId",
                principalTable: "FieldType",
                principalColumn: "FieldTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
