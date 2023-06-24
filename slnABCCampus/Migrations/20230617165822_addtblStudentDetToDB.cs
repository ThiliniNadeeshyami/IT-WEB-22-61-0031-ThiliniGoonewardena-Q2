using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace slnABCCampus.Migrations
{
    /// <inheritdoc />
    public partial class addtblStudentDetToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblStudents",
                table: "tblStudents");

            migrationBuilder.RenameTable(
                name: "tblStudents",
                newName: "tblStudentsDetail");

            migrationBuilder.AlterColumn<decimal>(
                name: "dCourseID",
                table: "tblStudentsDetail",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "dStudentID",
                table: "tblStudentsDetail",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblStudentsDetail",
                table: "tblStudentsDetail",
                column: "dStudentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblStudentsDetail",
                table: "tblStudentsDetail");

            migrationBuilder.RenameTable(
                name: "tblStudentsDetail",
                newName: "tblStudents");

            migrationBuilder.AlterColumn<int>(
                name: "dCourseID",
                table: "tblStudents",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "dStudentID",
                table: "tblStudents",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblStudents",
                table: "tblStudents",
                column: "dStudentID");
        }
    }
}
