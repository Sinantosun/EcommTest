using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommTest.Migrations
{
    public partial class migration_refresh3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_productDetails_ProductDetailID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductDetailID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductDetailID",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductsID",
                table: "productDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_productDetails_ProductsID",
                table: "productDetails",
                column: "ProductsID");

            migrationBuilder.AddForeignKey(
                name: "FK_productDetails_Products_ProductsID",
                table: "productDetails",
                column: "ProductsID",
                principalTable: "Products",
                principalColumn: "ProductsID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productDetails_Products_ProductsID",
                table: "productDetails");

            migrationBuilder.DropIndex(
                name: "IX_productDetails_ProductsID",
                table: "productDetails");

            migrationBuilder.DropColumn(
                name: "ProductsID",
                table: "productDetails");

            migrationBuilder.AddColumn<int>(
                name: "ProductDetailID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductDetailID",
                table: "Products",
                column: "ProductDetailID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_productDetails_ProductDetailID",
                table: "Products",
                column: "ProductDetailID",
                principalTable: "productDetails",
                principalColumn: "ProductDetailID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
