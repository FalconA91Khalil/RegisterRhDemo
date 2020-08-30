using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class AddFieldType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FieldType",
                table: "FormFields");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "FormFields",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "FieldTypeId",
                table: "FormFields",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Companies",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.CreateTable(
                name: "FieldType",
                columns: table => new
                {
                    FieldTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldType", x => x.FieldTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormFields_FieldTypeId",
                table: "FormFields",
                column: "FieldTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_FormFields_FieldType_FieldTypeId",
                table: "FormFields",
                column: "FieldTypeId",
                principalTable: "FieldType",
                principalColumn: "FieldTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormFields_FieldType_FieldTypeId",
                table: "FormFields");

            migrationBuilder.DropTable(
                name: "FieldType");

            migrationBuilder.DropIndex(
                name: "IX_FormFields_FieldTypeId",
                table: "FormFields");

            migrationBuilder.DropColumn(
                name: "FieldTypeId",
                table: "FormFields");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "FormFields",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FieldType",
                table: "FormFields",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Companies",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
