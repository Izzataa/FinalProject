using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marketo.DataAccess.Migrations
{
    public partial class SliderTablesCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ButtonUrl",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discount",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "Order",
                table: "Sliders",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "Order",
                table: "Abouts",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "SubTitle",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ButtonUrl",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "SubTitle",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Abouts");
        }
    }
}
