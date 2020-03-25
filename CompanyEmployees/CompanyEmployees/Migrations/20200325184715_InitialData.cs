using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyEmployees.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[] { new Guid("b8d0dfa1-527b-4613-9500-0558d537c089"), "1 Av 45 building", "Ukraine", "Horns and Bones" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[] { new Guid("817cb473-13d0-46e2-8e5e-a441fd3e5788"), "5 Av 6 building", "US", "It Cheese" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[] { new Guid("113628c7-d803-4df9-8c0e-2764852f2b33"), 33, new Guid("b8d0dfa1-527b-4613-9500-0558d537c089"), "Gordon Freeman", "Security manager" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[] { new Guid("abfa3918-6db6-485a-b5c4-37fba0ae2962"), 25, new Guid("b8d0dfa1-527b-4613-9500-0558d537c089"), "Alyx Vance", "Bartender" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[] { new Guid("a3716356-1a3b-4e46-99f0-cd907aa50b67"), 90000, new Guid("817cb473-13d0-46e2-8e5e-a441fd3e5788"), "Doom guy", "CTO" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("113628c7-d803-4df9-8c0e-2764852f2b33"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("a3716356-1a3b-4e46-99f0-cd907aa50b67"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("abfa3918-6db6-485a-b5c4-37fba0ae2962"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("817cb473-13d0-46e2-8e5e-a441fd3e5788"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("b8d0dfa1-527b-4613-9500-0558d537c089"));
        }
    }
}
