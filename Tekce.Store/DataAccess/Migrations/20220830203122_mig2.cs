using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecordDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdateContactDate",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "Changed",
                table: "Users",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChangedBy",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Users",
                type: "timestamp without time zone",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 30, 23, 31, 22, 192, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Changed",
                table: "Translates",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChangedBy",
                table: "Translates",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Translates",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Translates",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Changed",
                table: "OperationClaims",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChangedBy",
                table: "OperationClaims",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "OperationClaims",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "OperationClaims",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Changed",
                table: "MobileLogins",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChangedBy",
                table: "MobileLogins",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MobileLogins",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "MobileLogins",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Changed",
                table: "Languages",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChangedBy",
                table: "Languages",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Languages",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Languages",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Changed",
                table: "Groups",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChangedBy",
                table: "Groups",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Groups",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Groups",
                type: "integer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Changed",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ChangedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Changed",
                table: "Translates");

            migrationBuilder.DropColumn(
                name: "ChangedBy",
                table: "Translates");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Translates");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Translates");

            migrationBuilder.DropColumn(
                name: "Changed",
                table: "OperationClaims");

            migrationBuilder.DropColumn(
                name: "ChangedBy",
                table: "OperationClaims");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "OperationClaims");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OperationClaims");

            migrationBuilder.DropColumn(
                name: "Changed",
                table: "MobileLogins");

            migrationBuilder.DropColumn(
                name: "ChangedBy",
                table: "MobileLogins");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MobileLogins");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MobileLogins");

            migrationBuilder.DropColumn(
                name: "Changed",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "ChangedBy",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "Changed",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "ChangedBy",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Groups");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.AddColumn<DateTime>(
                name: "RecordDate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateContactDate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
