using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeOrganizerWebApi.Migrations
{
    public partial class SeedTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { new Guid("00000001-20db-4800-8d19-c7f7162900ec"), "Finance" },
                    { new Guid("00000002-20db-4800-8d19-c7f7162900ec"), "Sales" },
                    { new Guid("00000003-20db-4800-8d19-c7f7162900ec"), "Engineering" },
                    { new Guid("00000004-20db-4800-8d19-c7f7162900ec"), "Manufacturing" },
                    { new Guid("00000005-20db-4800-8d19-c7f7162900ec"), "Management" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfJoining", "DepartmentId", "EmployeeName", "PhotoFileName" },
                values: new object[,]
                {
                    { new Guid("00000001-1111-4800-8d19-c7f7162900ec"), new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000002-20db-4800-8d19-c7f7162900ec"), "Bilbo Baggins", "Bilbo Baggins00000005-20db-4800-8d19-c7f7162900ec.jpg" },
                    { new Guid("00000003-1111-4800-8d19-c7f7162900ec"), new DateTime(2019, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000002-20db-4800-8d19-c7f7162900ec"), "Alice Wonderland", "Alice Wonderland00000003-1111-4800-8d19-c7f7162900ec.jpg" },
                    { new Guid("00000004-1111-4800-8d19-c7f7162900ec"), new DateTime(2017, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000002-20db-4800-8d19-c7f7162900ec"), "Jack Sparrow", "Jack Sparrow00000004-1111-4800-8d19-c7f7162900ec.jpg" },
                    { new Guid("00000006-1111-4800-8d19-c7f7162900ec"), new DateTime(2018, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000003-20db-4800-8d19-c7f7162900ec"), "Stephen King", "Stephen King00000006-1111-4800-8d19-c7f7162900ec.jpg" },
                    { new Guid("00000007-1111-4800-8d19-c7f7162900ec"), new DateTime(2019, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000003-20db-4800-8d19-c7f7162900ec"), "Anna Karenina", "Stephen King00000007-1111-4800-8d19-c7f7162900ec.jpg" },
                    { new Guid("00000002-1111-4800-8d19-c7f7162900ec"), new DateTime(2018, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000004-20db-4800-8d19-c7f7162900ec"), "Tom Sawyer", "Tom Sawyer00000002-1111-4800-8d19-c7f7162900ec.jpg" },
                    { new Guid("00000005-1111-4800-8d19-c7f7162900ec"), new DateTime(2017, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000005-20db-4800-8d19-c7f7162900ec"), "John Snow", "John Snow00000005-1111-4800-8d19-c7f7162900ec.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("00000001-20db-4800-8d19-c7f7162900ec"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("00000001-1111-4800-8d19-c7f7162900ec"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("00000002-1111-4800-8d19-c7f7162900ec"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("00000003-1111-4800-8d19-c7f7162900ec"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("00000004-1111-4800-8d19-c7f7162900ec"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("00000005-1111-4800-8d19-c7f7162900ec"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("00000006-1111-4800-8d19-c7f7162900ec"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("00000007-1111-4800-8d19-c7f7162900ec"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("00000002-20db-4800-8d19-c7f7162900ec"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("00000003-20db-4800-8d19-c7f7162900ec"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("00000004-20db-4800-8d19-c7f7162900ec"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("00000005-20db-4800-8d19-c7f7162900ec"));
        }
    }
}
