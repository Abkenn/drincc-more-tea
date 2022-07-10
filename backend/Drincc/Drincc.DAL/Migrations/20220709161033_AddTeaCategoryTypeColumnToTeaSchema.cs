using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drincc.DAL.Migrations
{
    public partial class AddTeaCategoryTypeColumnToTeaSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Teas",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Teas");
        }
    }
}
