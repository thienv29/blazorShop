using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorShop.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColorDBProduct_ColorDBs_ColorDBsId",
                table: "ColorDBProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_ColorDBProduct_Products_ProductsId",
                table: "ColorDBProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ColorDBProduct",
                table: "ColorDBProduct");

            migrationBuilder.RenameTable(
                name: "ColorDBProduct",
                newName: "ColorDbProduct");

            migrationBuilder.RenameIndex(
                name: "IX_ColorDBProduct_ProductsId",
                table: "ColorDbProduct",
                newName: "IX_ColorDbProduct_ProductsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ColorDbProduct",
                table: "ColorDbProduct",
                columns: new[] { "ColorDBsId", "ProductsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ColorDbProduct_ColorDBs_ColorDBsId",
                table: "ColorDbProduct",
                column: "ColorDBsId",
                principalTable: "ColorDBs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColorDbProduct_Products_ProductsId",
                table: "ColorDbProduct",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColorDbProduct_ColorDBs_ColorDBsId",
                table: "ColorDbProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_ColorDbProduct_Products_ProductsId",
                table: "ColorDbProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ColorDbProduct",
                table: "ColorDbProduct");

            migrationBuilder.RenameTable(
                name: "ColorDbProduct",
                newName: "ColorDBProduct");

            migrationBuilder.RenameIndex(
                name: "IX_ColorDbProduct_ProductsId",
                table: "ColorDBProduct",
                newName: "IX_ColorDBProduct_ProductsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ColorDBProduct",
                table: "ColorDBProduct",
                columns: new[] { "ColorDBsId", "ProductsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ColorDBProduct_ColorDBs_ColorDBsId",
                table: "ColorDBProduct",
                column: "ColorDBsId",
                principalTable: "ColorDBs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColorDBProduct_Products_ProductsId",
                table: "ColorDBProduct",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
