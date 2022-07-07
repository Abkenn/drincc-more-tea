using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drincc.DAL.Migrations
{
    public partial class AddYearOfProductionAndDateBoughtToTeaSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateBought",
                table: "Teas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "YearOfProduction",
                table: "Teas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateBought",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "YearOfProduction",
                table: "Teas");
        }
    }
}
