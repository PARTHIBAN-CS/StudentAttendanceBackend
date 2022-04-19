using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class MyFirstMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateSequence<int>(
                name: "id",
                schema: "dbo");

            migrationBuilder.CreateSequence<int>(
                name: "rollno",
                schema: "dbo");

            migrationBuilder.AlterColumn<int>(
                name: "rollno",
                table: "Students",
                type: "integer",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR dbo.Order_seq",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "rollno");

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "NEXT VALUE FOR dbo.Order_seq"),
                    rollno = table.Column<int>(type: "integer", nullable: false),
                    mark1Value = table.Column<int>(type: "integer", nullable: false),
                    mark2Value = table.Column<int>(type: "integer", nullable: false),
                    mark3Value = table.Column<int>(type: "integer", nullable: false),
                    totalmarks = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropSequence(
                name: "id",
                schema: "dbo");

            migrationBuilder.DropSequence(
                name: "rollno",
                schema: "dbo");

            migrationBuilder.AlterColumn<int>(
                name: "rollno",
                table: "Students",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "NEXT VALUE FOR dbo.Order_seq");
        }
    }
}
