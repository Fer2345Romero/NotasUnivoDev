using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotasUnivoDev.Migrations
{
    /// <inheritdoc />
    public partial class CarrersSubjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CareersSubjects",
                columns: table => new
                {
                    CareerSubjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CareerId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    Cycle = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareersSubjects", x => x.CareerSubjectId);
                    table.ForeignKey(
                        name: "FK_CareersSubjects_Careers_CareerId",
                        column: x => x.CareerId,
                        principalTable: "Careers",
                        principalColumn: "CareerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CareersSubjects_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CareersSubjects_CareerId",
                table: "CareersSubjects",
                column: "CareerId");

            migrationBuilder.CreateIndex(
                name: "IX_CareersSubjects_SubjectId",
                table: "CareersSubjects",
                column: "SubjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CareersSubjects");
        }
    }
}
