using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBModel.Migrations
{
    public partial class relation_Unit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnitId",
                table: "Units",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnitId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Units_UnitId",
                table: "Units",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_UnitId",
                table: "Items",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Units_UnitId",
                table: "Items",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Units_Units_UnitId",
                table: "Units",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Units_UnitId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_Units_UnitId",
                table: "Units");

            migrationBuilder.DropIndex(
                name: "IX_Units_UnitId",
                table: "Units");

            migrationBuilder.DropIndex(
                name: "IX_Items_UnitId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "Items");
        }
    }
}
