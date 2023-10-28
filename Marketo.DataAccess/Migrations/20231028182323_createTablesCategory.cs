using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marketo.DataAccess.Migrations
{
    public partial class createTablesCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Furnitures",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Furnitures_CategoryId",
                table: "Furnitures",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Furnitures_Categories_CategoryId",
                table: "Furnitures",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Furnitures_Categories_CategoryId",
                table: "Furnitures");

            migrationBuilder.DropIndex(
                name: "IX_Furnitures_CategoryId",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Categories");
        }
    }
}
