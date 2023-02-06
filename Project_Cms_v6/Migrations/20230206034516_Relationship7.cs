using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Cms_v6.Migrations
{
    public partial class Relationship7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departements_Employees_Manager_Id",
                table: "Departements");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departements_Departments_Id",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departements",
                table: "Departements");

            migrationBuilder.RenameTable(
                name: "Departements",
                newName: "Departments");

            migrationBuilder.RenameIndex(
                name: "IX_Departements_Manager_Id",
                table: "Departments",
                newName: "IX_Departments_Manager_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_Manager_Id",
                table: "Departments",
                column: "Manager_Id",
                principalTable: "Employees",
                principalColumn: "NIK");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_Departments_Id",
                table: "Employees",
                column: "Departments_Id",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_Manager_Id",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_Departments_Id",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Departements");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_Manager_Id",
                table: "Departements",
                newName: "IX_Departements_Manager_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departements",
                table: "Departements",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departements_Employees_Manager_Id",
                table: "Departements",
                column: "Manager_Id",
                principalTable: "Employees",
                principalColumn: "NIK");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departements_Departments_Id",
                table: "Employees",
                column: "Departments_Id",
                principalTable: "Departements",
                principalColumn: "Id");
        }
    }
}
