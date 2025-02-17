using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProblemAnalysis1.Migrations
{
    /// <inheritdoc />
    public partial class RecreateInitialPart1Part2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Program",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Key = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Program", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    DateofBirth = table.Column<string>(type: "TEXT", nullable: false),
                    GPA = table.Column<decimal>(type: "TEXT", nullable: false),
                    StudentSchoolNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    ProgramId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Program_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "Program",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Program",
                columns: new[] { "Id", "Key", "Name" },
                values: new object[,]
                {
                    { 1, "CP", "Computer Programmer" },
                    { 2, "CPA", "Computer Programmer Analyst" },
                    { 3, "BACS", "Bacheleor of Applied Computer Science" },
                    { 4, "BCS", "Bacheleor of Computer Science (Honours)" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "DateofBirth", "FirstName", "GPA", "LastName", "ProgramId", "StudentSchoolNumber" },
                values: new object[,]
                {
                    { 1, "1971-05-31", "Bart", 2.7m, "Simpson", 1, 87654321 },
                    { 2, "1973-08-05", "Lisa", 2.2m, "Simpson", 3, 87654322 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_ProgramId",
                table: "Student",
                column: "ProgramId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Program");
        }
    }
}
