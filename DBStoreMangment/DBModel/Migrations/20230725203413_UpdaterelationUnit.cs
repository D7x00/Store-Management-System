using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBModel.Migrations
{
    public partial class UpdaterelationUnit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Units_Units_UnitId",
                table: "Units");

            migrationBuilder.DropIndex(
                name: "IX_Units_UnitId",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "Units");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnitId",
                table: "Units",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Units_UnitId",
                table: "Units",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Units_Units_UnitId",
                table: "Units",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id");
        }
    }
}
