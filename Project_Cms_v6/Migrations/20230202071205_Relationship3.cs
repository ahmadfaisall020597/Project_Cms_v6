using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Cms_v6.Migrations
{
    public partial class Relationship3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departements_Departments_Id",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Departements_Id",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "Departments_Id",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departements_Departments_Id",
                table: "Employees",
                column: "Departments_Id",
                principalTable: "Departements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departements_Departments_Id",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "Departments_Id",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Departements_Id",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departements_Departments_Id",
                table: "Employees",
                column: "Departments_Id",
                principalTable: "Departements",
                principalColumn: "Id");
        }
    }
}
