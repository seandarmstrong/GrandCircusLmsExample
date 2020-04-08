using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GrandCircusLmsExample.DAL.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedDate", "DateOfBirth", "DeclaredMajor", "FirstName", "GCIdentificationNumbe", "LastName", "LastUpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Computer Science", "Jake", "12001", "Collins", new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1994, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Computer Science", "Austin", "12002", "Powel", new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1998, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Computer Science", "Dylan", "12003", "Rule", new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1997, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Computer Science", "Andrew", "12004", "Waltman", new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Local) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
