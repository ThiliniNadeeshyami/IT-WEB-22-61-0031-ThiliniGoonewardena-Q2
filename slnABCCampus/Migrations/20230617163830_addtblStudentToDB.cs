using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace slnABCCampus.Migrations
{
    /// <inheritdoc />
    public partial class addtblStudentToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblStudentsDet",
                table: "tblStudentsDet");

            migrationBuilder.RenameTable(
                name: "tblStudentsDet",
                newName: "tblStudents");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblStudents",
                table: "tblStudents",
                column: "dStudentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblStudents",
                table: "tblStudents");

            migrationBuilder.RenameTable(
                name: "tblStudents",
                newName: "tblStudentsDet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblStudentsDet",
                table: "tblStudentsDet",
                column: "dStudentID");
        }
    }
}
