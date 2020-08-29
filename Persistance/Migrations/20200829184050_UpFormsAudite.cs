using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class UpFormsAudite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "FormFields",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "FormFields",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "FormFields",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "FormFields",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "FormFields",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "FormFields",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "FormFields",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "FormFields");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "FormFields");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "FormFields");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "FormFields");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "FormFields");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "FormFields");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "FormFields");
        }
    }
}
