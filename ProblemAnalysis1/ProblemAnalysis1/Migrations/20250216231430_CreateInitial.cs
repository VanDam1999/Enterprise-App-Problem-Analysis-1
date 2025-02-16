using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProblemAnalysis1.Migrations
{
    /// <inheritdoc />
    public partial class CreateInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    DateofBirth = table.Column<string>(type: "TEXT", nullable: false),
                    GPA = table.Column<float>(type: "REAL", nullable: false),
                    StudentSchoolNumber = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "DateofBirth", "FirstName", "GPA", "LastName", "StudentSchoolNumber" },
                values: new object[,]
                {
                    { 1, "1971-05-31", "Bart", 2.7f, "Simpson", 87654321 },
                    { 2, "1973-08-05", "Lisa", 2.2f, "Simpson", 87654322 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
