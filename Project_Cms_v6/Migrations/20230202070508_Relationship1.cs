using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Cms_v6.Migrations
{
    public partial class Relationship1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountRoles",
                table: "AccountRoles");

            migrationBuilder.DropIndex(
                name: "IX_AccountRoles_AccountNIK",
                table: "AccountRoles");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AccountRoles",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountRoles",
                table: "AccountRoles",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AccountRoles_AccountNIK",
                table: "AccountRoles",
                column: "AccountNIK");

            migrationBuilder.CreateIndex(
                name: "IX_AccountRoles_RoleId",
                table: "AccountRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountRoles",
                table: "AccountRoles");

            migrationBuilder.DropIndex(
                name: "IX_AccountRoles_AccountNIK",
                table: "AccountRoles");

            migrationBuilder.DropIndex(
                name: "IX_AccountRoles_RoleId",
                table: "AccountRoles");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AccountRoles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountRoles",
                table: "AccountRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountRoles_AccountNIK",
                table: "AccountRoles",
                column: "AccountNIK",
                unique: true);
        }
    }
}
