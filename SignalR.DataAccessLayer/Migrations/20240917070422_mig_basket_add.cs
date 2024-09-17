using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DataAccessLayer.Migrations
{
    public partial class mig_basket_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Basket_MenuTables_MenuTableID",
                table: "Basket");

            migrationBuilder.DropForeignKey(
                name: "FK_Basket_Products_ProductID",
                table: "Basket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Basket",
                table: "Basket");

            migrationBuilder.RenameTable(
                name: "Basket",
                newName: "Baskets");

            migrationBuilder.RenameIndex(
                name: "IX_Basket_ProductID",
                table: "Baskets",
                newName: "IX_Baskets_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_Basket_MenuTableID",
                table: "Baskets",
                newName: "IX_Baskets_MenuTableID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Baskets",
                table: "Baskets",
                column: "BasketID");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_MenuTables_MenuTableID",
                table: "Baskets",
                column: "MenuTableID",
                principalTable: "MenuTables",
                principalColumn: "MenuTableID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Products_ProductID",
                table: "Baskets",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_MenuTables_MenuTableID",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Products_ProductID",
                table: "Baskets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Baskets",
                table: "Baskets");

            migrationBuilder.RenameTable(
                name: "Baskets",
                newName: "Basket");

            migrationBuilder.RenameIndex(
                name: "IX_Baskets_ProductID",
                table: "Basket",
                newName: "IX_Basket_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_Baskets_MenuTableID",
                table: "Basket",
                newName: "IX_Basket_MenuTableID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Basket",
                table: "Basket",
                column: "BasketID");

            migrationBuilder.AddForeignKey(
                name: "FK_Basket_MenuTables_MenuTableID",
                table: "Basket",
                column: "MenuTableID",
                principalTable: "MenuTables",
                principalColumn: "MenuTableID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Basket_Products_ProductID",
                table: "Basket",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
