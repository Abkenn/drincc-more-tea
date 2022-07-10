using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drincc.DAL.Migrations
{
    public partial class UpdateTeaFKInSessionNotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SessionNotes_Teas_TeaId1",
                table: "SessionNotes");

            migrationBuilder.DropIndex(
                name: "IX_SessionNotes_TeaId1",
                table: "SessionNotes");

            migrationBuilder.DropColumn(
                name: "TeaId1",
                table: "SessionNotes");

            migrationBuilder.AlterColumn<long>(
                name: "TeaId",
                table: "SessionNotes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_SessionNotes_TeaId",
                table: "SessionNotes",
                column: "TeaId");

            migrationBuilder.AddForeignKey(
                name: "FK_SessionNotes_Teas_TeaId",
                table: "SessionNotes",
                column: "TeaId",
                principalTable: "Teas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SessionNotes_Teas_TeaId",
                table: "SessionNotes");

            migrationBuilder.DropIndex(
                name: "IX_SessionNotes_TeaId",
                table: "SessionNotes");

            migrationBuilder.AlterColumn<int>(
                name: "TeaId",
                table: "SessionNotes",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "TeaId1",
                table: "SessionNotes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_SessionNotes_TeaId1",
                table: "SessionNotes",
                column: "TeaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_SessionNotes_Teas_TeaId1",
                table: "SessionNotes",
                column: "TeaId1",
                principalTable: "Teas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
