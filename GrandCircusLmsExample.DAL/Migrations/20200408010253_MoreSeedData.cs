using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GrandCircusLmsExample.DAL.Migrations
{
    public partial class MoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "CreatedDate", "DateOfBirth", "FirstName", "GCIdentificationNumbe", "LastName", "LastUpdatedDate", "OfficeNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1984, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sean", "101", "Armstrong", new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "A1" },
                    { 2, new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1986, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albert", "102", "Ngoudjou", new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "C3" },
                    { 3, new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1991, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tommy", "102", "Waalkes", new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "AA5" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "City", "CreatedDate", "LastUpdatedDate", "Name", "State" },
                values: new object[] { 1, "40 Pearl St NW", "Grand Rapids", new DateTime(2020, 4, 7, 21, 2, 52, 50, DateTimeKind.Local).AddTicks(7059), new DateTime(2020, 4, 7, 21, 2, 52, 50, DateTimeKind.Local).AddTicks(7070), "Start Garden", "Michigan" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CreatedDate", "Credits", "LastUpdatedDate", "LocationId", "Name" },
                values: new object[] { 1, new DateTime(2020, 4, 7, 21, 2, 52, 50, DateTimeKind.Local).AddTicks(9574), 4, new DateTime(2020, 4, 7, 21, 2, 52, 50, DateTimeKind.Local).AddTicks(9585), 1, "C# Back-end" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CreatedDate", "Credits", "LastUpdatedDate", "LocationId", "Name" },
                values: new object[] { 2, new DateTime(2020, 4, 7, 21, 2, 52, 50, DateTimeKind.Local).AddTicks(9617), 3, new DateTime(2020, 4, 7, 21, 2, 52, 50, DateTimeKind.Local).AddTicks(9620), 1, "Coolest Front End Ever" });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "CourseId", "CreatedDate", "Grade", "LastUpdatedDate", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 4, 7, 21, 2, 52, 51, DateTimeKind.Local).AddTicks(1457), null, new DateTime(2020, 4, 7, 21, 2, 52, 51, DateTimeKind.Local).AddTicks(1468), 1 },
                    { 2, 1, new DateTime(2020, 4, 7, 21, 2, 52, 51, DateTimeKind.Local).AddTicks(1495), null, new DateTime(2020, 4, 7, 21, 2, 52, 51, DateTimeKind.Local).AddTicks(1499), 2 },
                    { 3, 1, new DateTime(2020, 4, 7, 21, 2, 52, 51, DateTimeKind.Local).AddTicks(1503), null, new DateTime(2020, 4, 7, 21, 2, 52, 51, DateTimeKind.Local).AddTicks(1506), 3 },
                    { 4, 1, new DateTime(2020, 4, 7, 21, 2, 52, 51, DateTimeKind.Local).AddTicks(1510), null, new DateTime(2020, 4, 7, 21, 2, 52, 51, DateTimeKind.Local).AddTicks(1513), 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
