using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FastFood.DataLayer.Migrations
{
    public partial class FastFood : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StoreInvoicingDetails",
                columns: table => new
                {
                    InvoicingDetailId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoicingId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CurrentPrice = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LaborCustomerItem = table.Column<int>(type: "int", nullable: false),
                    InvoicingDetailCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoicingDetailUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoicingDetailDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoicingDetailStatus = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreInvoicingDetails", x => x.InvoicingDetailId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductPreparationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductPicUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    StoreInvoicingDetailsInvoicingDetailId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_StoreInvoicingDetails_StoreInvoicingDetailsInvoicingDetailId",
                        column: x => x.StoreInvoicingDetailsInvoicingDetailId,
                        principalTable: "StoreInvoicingDetails",
                        principalColumn: "InvoicingDetailId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StoreInvoicings",
                columns: table => new
                {
                    InvoicingId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    StoreInvoicingCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StoreInvoicingUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StoreInvoicingDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StoreInvoicingStatus = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    StoreInvoicingDetailsInvoicingDetailId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreInvoicings", x => x.InvoicingId);
                    table.ForeignKey(
                        name: "FK_StoreInvoicings_StoreInvoicingDetails_StoreInvoicingDetailsInvoicingDetailId",
                        column: x => x.StoreInvoicingDetailsInvoicingDetailId,
                        principalTable: "StoreInvoicingDetails",
                        principalColumn: "InvoicingDetailId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    ProductsProductID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                    table.ForeignKey(
                        name: "FK_Categories_Products_ProductsProductID",
                        column: x => x.ProductsProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Mobile = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    StatusCustomer = table.Column<int>(type: "int", nullable: false),
                    PasswordCustomer = table.Column<int>(type: "int", nullable: false),
                    CustomerCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    StoreInvoicingInvoicingId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_StoreInvoicings_StoreInvoicingInvoicingId",
                        column: x => x.StoreInvoicingInvoicingId,
                        principalTable: "StoreInvoicings",
                        principalColumn: "InvoicingId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ProductsProductID",
                table: "Categories",
                column: "ProductsProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_StoreInvoicingInvoicingId",
                table: "Customers",
                column: "StoreInvoicingInvoicingId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StoreInvoicingDetailsInvoicingDetailId",
                table: "Products",
                column: "StoreInvoicingDetailsInvoicingDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreInvoicings_StoreInvoicingDetailsInvoicingDetailId",
                table: "StoreInvoicings",
                column: "StoreInvoicingDetailsInvoicingDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "StoreInvoicings");

            migrationBuilder.DropTable(
                name: "StoreInvoicingDetails");
        }
    }
}
