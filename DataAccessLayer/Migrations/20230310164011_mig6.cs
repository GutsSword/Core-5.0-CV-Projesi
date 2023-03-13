using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_userMessageNews",
                table: "userMessageNews");

            migrationBuilder.RenameTable(
                name: "userMessageNews",
                newName: "UserMessageNews");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserMessageNews",
                table: "UserMessageNews",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserMessageNews",
                table: "UserMessageNews");

            migrationBuilder.RenameTable(
                name: "UserMessageNews",
                newName: "userMessageNews");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userMessageNews",
                table: "userMessageNews",
                column: "ID");
        }
    }
}
