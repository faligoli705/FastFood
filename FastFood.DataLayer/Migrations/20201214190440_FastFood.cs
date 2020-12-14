using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FastFood.DataLayer.Migrations
{
    public partial class FastFood : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    IdType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.IdType);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    NationalCode = table.Column<int>(type: "int", nullable: false),
                    Mobile = table.Column<int>(type: "int", nullable: false),
                    AddressUser = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    PicUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusAdmin = table.Column<int>(type: "int", nullable: false),
                    Pass = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    IdProducts = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameFood = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    IdType = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateSave = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeSave = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeAmadehSazi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PicUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    TypesIdType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.IdProducts);
                    table.ForeignKey(
                        name: "FK_Products_Types_TypesIdType",
                        column: x => x.TypesIdType,
                        principalTable: "Types",
                        principalColumn: "IdType",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Factors",
                columns: table => new
                {
                    IdFactor = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    IdProdut = table.Column<int>(type: "int", nullable: false),
                    DateSave = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeSave = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddressUser = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QtyFood = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    UserIdUser = table.Column<int>(type: "int", nullable: true),
                    ProductsIdProducts = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factors", x => x.IdFactor);
                    table.ForeignKey(
                        name: "FK_Factors_Products_ProductsIdProducts",
                        column: x => x.ProductsIdProducts,
                        principalTable: "Products",
                        principalColumn: "IdProducts",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factors_Users_UserIdUser",
                        column: x => x.UserIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Factors_ProductsIdProducts",
                table: "Factors",
                column: "ProductsIdProducts");

            migrationBuilder.CreateIndex(
                name: "IX_Factors_UserIdUser",
                table: "Factors",
                column: "UserIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TypesIdType",
                table: "Products",
                column: "TypesIdType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Factors");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
