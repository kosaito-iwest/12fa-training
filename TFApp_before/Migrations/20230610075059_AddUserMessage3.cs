using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TFApp.Migrations
{
    public partial class AddUserMessage3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Message",
                table: "User",
                newName: "message3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "message3",
                table: "User",
                newName: "Message");
        }
    }
}
