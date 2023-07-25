using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBModel.Migrations
{
    public partial class RIRC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_admins",
                table: "admins");

            migrationBuilder.RenameTable(
                name: "admins",
                newName: "Admins");

            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admins",
                table: "Admins",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Companys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CompanyLocation = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "itemStores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itemStores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_itemStores_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_itemStores_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receivings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceivingData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VendorId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receivings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receivings_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receivings_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceivingItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ReceivingId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceivingItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceivingItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceivingItems_Receivings_ReceivingId",
                        column: x => x.ReceivingId,
                        principalTable: "Receivings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceivingItems_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_DeptId",
                table: "Items",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_itemStores_ItemId",
                table: "itemStores",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_itemStores_StoreId",
                table: "itemStores",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceivingItems_ItemId",
                table: "ReceivingItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceivingItems_ReceivingId",
                table: "ReceivingItems",
                column: "ReceivingId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceivingItems_StoreId",
                table: "ReceivingItems",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Receivings_EmployeeId",
                table: "Receivings",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Receivings_VendorId",
                table: "Receivings",
                column: "VendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Departments_DeptId",
                table: "Items",
                column: "DeptId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Departments_DeptId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "Companys");

            migrationBuilder.DropTable(
                name: "itemStores");

            migrationBuilder.DropTable(
                name: "ReceivingItems");

            migrationBuilder.DropTable(
                name: "Receivings");

            migrationBuilder.DropIndex(
                name: "IX_Items_DeptId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admins",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Admins",
                newName: "admins");

            migrationBuilder.AddPrimaryKey(
                name: "PK_admins",
                table: "admins",
                column: "Id");
        }
    }
}
