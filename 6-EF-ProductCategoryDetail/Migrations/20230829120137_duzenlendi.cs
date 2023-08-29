using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _6_EF_ProductCategoryDetail.Migrations
{
    public partial class duzenlendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Products_ProductId",
                table: "ProductDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "DetailId",
                table: "Products",
                newName: "CategoryRefId");

            migrationBuilder.RenameColumn(
                name: "Weight",
                table: "ProductDetails",
                newName: "Width");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductDetails",
                newName: "ProductRefId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductDetails_ProductId",
                table: "ProductDetails",
                newName: "IX_ProductDetails_ProductRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryRefId",
                table: "Products",
                column: "CategoryRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Products_ProductRefId",
                table: "ProductDetails",
                column: "ProductRefId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryRefId",
                table: "Products",
                column: "CategoryRefId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Products_ProductRefId",
                table: "ProductDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryRefId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryRefId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "CategoryRefId",
                table: "Products",
                newName: "DetailId");

            migrationBuilder.RenameColumn(
                name: "Width",
                table: "ProductDetails",
                newName: "Weight");

            migrationBuilder.RenameColumn(
                name: "ProductRefId",
                table: "ProductDetails",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductDetails_ProductRefId",
                table: "ProductDetails",
                newName: "IX_ProductDetails_ProductId");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Products_ProductId",
                table: "ProductDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
