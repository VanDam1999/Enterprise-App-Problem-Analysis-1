using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProblemAnalysis1.Migrations
{
    /// <inheritdoc />
    public partial class RecreateInitialPart1Part21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateofBirth",
                value: "5/31/1971");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateofBirth",
                value: "8/5/1973");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateofBirth",
                value: "1971-05-31");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateofBirth",
                value: "1973-08-05");
        }
    }
}
