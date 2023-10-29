using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marketo.DataAccess.Migrations
{
    public partial class createBasketItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "BasketItems",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FurnitureId",
                table: "BasketItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "BasketItems",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "BasketItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_AppUserId",
                table: "BasketItems",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_FurnitureId",
                table: "BasketItems",
                column: "FurnitureId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_AspNetUsers_AppUserId",
                table: "BasketItems",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_Furnitures_FurnitureId",
                table: "BasketItems",
                column: "FurnitureId",
                principalTable: "Furnitures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_AspNetUsers_AppUserId",
                table: "BasketItems");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_Furnitures_FurnitureId",
                table: "BasketItems");

            migrationBuilder.DropIndex(
                name: "IX_BasketItems_AppUserId",
                table: "BasketItems");

            migrationBuilder.DropIndex(
                name: "IX_BasketItems_FurnitureId",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "FurnitureId",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "BasketItems");
        }
    }
}
