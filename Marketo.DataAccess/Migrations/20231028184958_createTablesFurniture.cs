using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marketo.DataAccess.Migrations
{
    public partial class createTablesFurniture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Furnitures_Categories_CategoryId",
                table: "Furnitures");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Furnitures",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Article",
                table: "Furnitures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BestSeller",
                table: "Furnitures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FurnitureDescriptionId",
                table: "Furnitures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Furnitures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Furnitures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Furnitures",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "SKU",
                table: "Furnitures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Stock",
                table: "Furnitures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Trend",
                table: "Furnitures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Alternative",
                table: "FurnitureImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FurnitureId",
                table: "FurnitureImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "FurnitureImages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "FurnitureImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "FurnitureDescriptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FurnitureId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Furnitures_FurnitureDescriptionId",
                table: "Furnitures",
                column: "FurnitureDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_FurnitureImages_FurnitureId",
                table: "FurnitureImages",
                column: "FurnitureId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_FurnitureId",
                table: "Comments",
                column: "FurnitureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Furnitures_FurnitureId",
                table: "Comments",
                column: "FurnitureId",
                principalTable: "Furnitures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FurnitureImages_Furnitures_FurnitureId",
                table: "FurnitureImages",
                column: "FurnitureId",
                principalTable: "Furnitures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Furnitures_Categories_CategoryId",
                table: "Furnitures",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Furnitures_FurnitureDescriptions_FurnitureDescriptionId",
                table: "Furnitures",
                column: "FurnitureDescriptionId",
                principalTable: "FurnitureDescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Furnitures_FurnitureId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_FurnitureImages_Furnitures_FurnitureId",
                table: "FurnitureImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Furnitures_Categories_CategoryId",
                table: "Furnitures");

            migrationBuilder.DropForeignKey(
                name: "FK_Furnitures_FurnitureDescriptions_FurnitureDescriptionId",
                table: "Furnitures");

            migrationBuilder.DropIndex(
                name: "IX_Furnitures_FurnitureDescriptionId",
                table: "Furnitures");

            migrationBuilder.DropIndex(
                name: "IX_FurnitureImages_FurnitureId",
                table: "FurnitureImages");

            migrationBuilder.DropIndex(
                name: "IX_Comments_FurnitureId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Article",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "BestSeller",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "FurnitureDescriptionId",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "SKU",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Trend",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Alternative",
                table: "FurnitureImages");

            migrationBuilder.DropColumn(
                name: "FurnitureId",
                table: "FurnitureImages");

            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "FurnitureImages");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "FurnitureImages");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "FurnitureDescriptions");

            migrationBuilder.DropColumn(
                name: "FurnitureId",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Furnitures",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Furnitures_Categories_CategoryId",
                table: "Furnitures",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
