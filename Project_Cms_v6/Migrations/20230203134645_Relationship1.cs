using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Cms_v6.Migrations
{
    public partial class Relationship1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Id_Roles",
                table: "AccountRoles",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_Roles",
                table: "AccountRoles");
        }
    }
}
