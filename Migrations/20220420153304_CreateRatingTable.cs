using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_School_DB_Managment.Migrations
{
    public partial class CreateRatingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Lessons");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "TimeTables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 20, 19, 18, 3, 391, DateTimeKind.Local).AddTicks(1439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 20, 16, 51, 40, 663, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginTime",
                table: "TimeTables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 20, 18, 33, 3, 385, DateTimeKind.Local).AddTicks(6113),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 20, 16, 6, 40, 649, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true, defaultValue: ""),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Rate = table.Column<short>(type: "smallint", maxLength: 13, nullable: false, defaultValue: (short)0),
                    Comment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValue: ""),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_StudentId",
                table: "Ratings",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "TimeTables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 20, 16, 51, 40, 663, DateTimeKind.Local).AddTicks(1363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 20, 19, 18, 3, 391, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginTime",
                table: "TimeTables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 20, 16, 6, 40, 649, DateTimeKind.Local).AddTicks(2349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 20, 18, 33, 3, 385, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Lessons",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<short>(
                name: "Rate",
                table: "Lessons",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }
    }
}
