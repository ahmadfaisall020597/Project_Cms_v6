using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Cms_v6.Migrations
{
    public partial class Relationship5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Admin",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "Employee",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "Manager",
                table: "Roles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Admin",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Employee",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Manager",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
