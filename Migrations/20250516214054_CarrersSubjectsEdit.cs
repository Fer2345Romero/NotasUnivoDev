using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotasUnivoDev.Migrations
{
    /// <inheritdoc />
    public partial class CarrersSubjectsEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "CareersSubjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CareersSubjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Edited",
                table: "CareersSubjects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EditedBy",
                table: "CareersSubjects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "CareersSubjects",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "CareersSubjects");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CareersSubjects");

            migrationBuilder.DropColumn(
                name: "Edited",
                table: "CareersSubjects");

            migrationBuilder.DropColumn(
                name: "EditedBy",
                table: "CareersSubjects");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "CareersSubjects");
        }
    }
}
