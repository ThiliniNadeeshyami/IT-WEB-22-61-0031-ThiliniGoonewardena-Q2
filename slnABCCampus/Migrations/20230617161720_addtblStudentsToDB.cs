using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace slnABCCampus.Migrations
{
    /// <inheritdoc />
    public partial class addtblStudentsToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblStudentsDet",
                columns: table => new
                {
                    dStudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    szStudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    szCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dCourseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStudentsDet", x => x.dStudentID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblStudentsDet");
        }
    }
}
