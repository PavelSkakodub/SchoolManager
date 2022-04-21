using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_School_DB_Managment.Migrations
{
    public partial class AddIndexToTimeAndRatingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Ratings_StudentId",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_ClassId",
                table: "Lessons");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "TimeTables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 21, 16, 4, 43, 204, DateTimeKind.Local).AddTicks(6532),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 20, 19, 18, 3, 391, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginTime",
                table: "TimeTables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 21, 15, 19, 43, 194, DateTimeKind.Local).AddTicks(1176),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 20, 18, 33, 3, 385, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.CreateIndex(
                name: "IX_TimeTables_DayOfWeek",
                table: "TimeTables",
                column: "DayOfWeek");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_StudentId_Date",
                table: "Ratings",
                columns: new[] { "StudentId", "Date" });

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_ClassId_Date",
                table: "Lessons",
                columns: new[] { "ClassId", "Date" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TimeTables_DayOfWeek",
                table: "TimeTables");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_StudentId_Date",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_ClassId_Date",
                table: "Lessons");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "TimeTables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 20, 19, 18, 3, 391, DateTimeKind.Local).AddTicks(1439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 21, 16, 4, 43, 204, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginTime",
                table: "TimeTables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 20, 18, 33, 3, 385, DateTimeKind.Local).AddTicks(6113),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 21, 15, 19, 43, 194, DateTimeKind.Local).AddTicks(1176));

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_StudentId",
                table: "Ratings",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_ClassId",
                table: "Lessons",
                column: "ClassId");
        }
    }
}
