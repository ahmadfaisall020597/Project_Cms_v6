using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Cms_v6.Migrations
{
    public partial class Relationship2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departements_DepartementsId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "DepartementsId",
                table: "Employees",
                newName: "Departments_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DepartementsId",
                table: "Employees",
                newName: "IX_Employees_Departments_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departements_Departments_Id",
                table: "Employees",
                column: "Departments_Id",
                principalTable: "Departements",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departements_Departments_Id",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "Departments_Id",
                table: "Employees",
                newName: "DepartementsId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_Departments_Id",
                table: "Employees",
                newName: "IX_Employees_DepartementsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departements_DepartementsId",
                table: "Employees",
                column: "DepartementsId",
                principalTable: "Departements",
                principalColumn: "Id");
        }
    }
}
