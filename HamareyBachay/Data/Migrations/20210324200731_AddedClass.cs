using Microsoft.EntityFrameworkCore.Migrations;

namespace HamareyBachay.Data.Migrations
{
    public partial class AddedClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Student",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClassId1",
                table: "Student",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassSectionId",
                table: "Student",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SectionId",
                table: "Student",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    ClassId = table.Column<int>(nullable: false),
                    SectionId = table.Column<int>(nullable: false),
                    MinAgeLimit = table.Column<int>(nullable: false),
                    MaxAgeLimit = table.Column<int>(nullable: false),
                    NumOfStudents = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => new { x.ClassId, x.SectionId });
                    table.ForeignKey(
                        name: "FK_Class_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_ClassId1_ClassSectionId",
                table: "Student",
                columns: new[] { "ClassId1", "ClassSectionId" });

            migrationBuilder.CreateIndex(
                name: "IX_Class_CourseId",
                table: "Class",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Class_ClassId1_ClassSectionId",
                table: "Student",
                columns: new[] { "ClassId1", "ClassSectionId" },
                principalTable: "Class",
                principalColumns: new[] { "ClassId", "SectionId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Class_ClassId1_ClassSectionId",
                table: "Student");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropIndex(
                name: "IX_Student_ClassId1_ClassSectionId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "ClassId1",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "ClassSectionId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "Student");
        }
    }
}
