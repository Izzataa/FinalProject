using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marketo.DataAccess.Migrations
{
    public partial class createTablesNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Settings_Key",
                table: "Settings");

            migrationBuilder.AddColumn<int>(
                name: "OrderItemNumberId",
                table: "Sliders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Furnitures",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

            migrationBuilder.CreateTable(
                name: "Numbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Numbers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sliders_OrderItemNumberId",
                table: "Sliders",
                column: "OrderItemNumberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sliders_Numbers_OrderItemNumberId",
                table: "Sliders",
                column: "OrderItemNumberId",
                principalTable: "Numbers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sliders_Numbers_OrderItemNumberId",
                table: "Sliders");

            migrationBuilder.DropTable(
                name: "Numbers");

            migrationBuilder.DropIndex(
                name: "IX_Sliders_OrderItemNumberId",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "OrderItemNumberId",
                table: "Sliders");

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "Settings",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Furnitures",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateIndex(
                name: "IX_Settings_Key",
                table: "Settings",
                column: "Key",
                unique: true);
        }
    }
}
