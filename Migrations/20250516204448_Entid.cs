using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotasUnivoDev.Migrations
{
    /// <inheritdoc />
    public partial class Entid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubjetctId",
                table: "Subjects",
                newName: "SubjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "Subjects",
                newName: "SubjetctId");
        }
    }
}
